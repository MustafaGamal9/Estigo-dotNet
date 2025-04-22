using Estigo.DTO;
using Estigo.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static Estigo.Enums.CourseStatus;

namespace Estigo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        EstigoDbContext context;
        public AdminController(EstigoDbContext _context)
        {
            context = _context;
        }

        [HttpGet("AllStudent")]
        public IActionResult GetAllStudent()
        {

            List<Student> students =
                context.Students.ToList();

            return Ok(students);
        }

        [HttpGet("student/search")]
        public async Task<ActionResult<DashboardDTO>> GetStudentDashboard([FromQuery] string query)
        {
            // التحقق من أن المستخدم أدخل استعلام
            if (string.IsNullOrEmpty(query))
            {
                return BadRequest("Please provide a student name or code.");
            }

            // تجهيز الاستعلام
            var studentQuery = context.Students.AsQueryable();

            // محاولة تحويل الاستعلام إلى كود
            if (int.TryParse(query, out int code))
            {
                studentQuery = studentQuery.Where(s => s.StudentCode == code);
            }
            else
            {
                studentQuery = studentQuery.Where(s => s.Name.Contains(query));
            }

            // الحصول على الطالب
            var student = await studentQuery.FirstOrDefaultAsync();

            if (student == null)
            {
                return NotFound("Student not found.");
            }

            string studentId = student.Id;

            // --- الكورسات المسجل فيها الطالب ---
            var enrolledCourses = await context.MyCourses
                .Where(mc => mc.StudentId == studentId)
                .Include(mc => mc.Course)
                .Select(mc => mc.Course)
                .Where(c => c != null)
                .OrderBy(c => c.CourseTitle)
                .Take(3)
                .Select(c => new EnrolledCourseDTO
                {
                    CourseId = c.CourseId,
                    CourseName = c.CourseTitle,
                    CourseImageUrl = c.Logo
                })
                .ToListAsync();

            // --- المدرسين ---
            var courseInstructors = await context.MyCourses
                .Where(mc => mc.StudentId == studentId)
                .Include(mc => mc.Course)
                    .ThenInclude(c => c.Teacher)
                .Select(mc => mc.Course.Teacher)
                .Distinct()
                .Take(3)
                .Select(t => new InstructorImageDTO
                {
                    InstructorImageUrl = t.image
                })
                .ToListAsync();

            // --- اختبارات الكورسات ---
            var enrolledCourseIds = await context.MyCourses
                .Where(mc => mc.StudentId == studentId)
                .Select(mc => mc.CourseId)
                .Distinct()
                .ToListAsync();

            var lessonIds = await context.lessons
                .Where(l => enrolledCourseIds.Contains(l.courseId))
                .Select(l => l.lessonId)
                .ToListAsync();

            var quizzes = await context.Exams
                .Where(q => lessonIds.Contains(q.lessonId))
                .Take(2)
                .Select(q => new QuizInfoDTO
                {
                    QuizId = q.Id,
                    QuizName = q.ExamTitle
                })
                .ToListAsync();

            // --- الدفع ---
            var paymentInfo = await context.Payments
                .Where(p => p.StudentId == studentId)
                .Take(2)
                .Select(p => new PaymentInfoDTO
                {
                    PurchaseDate = p.PurchaseDate,
                    CourseTitle = p.Course.CourseTitle
                })
                .ToListAsync();

            // --- تجميع البيانات ---
            var dashboardData = new
            {
                StudentId = student.Id,
                StudentName = student.Name,
                StudentCode = student.StudentCode.ToString(),
                EnrolledCourses = enrolledCourses,
                CourseInstructors = courseInstructors,
                Quizzes = quizzes,
                PaymentInfo = paymentInfo
            };

            return Ok(dashboardData);
        }


        [HttpDelete("{studentId}")]
        public async Task<ActionResult> DeleteStudent([FromRoute] string studentId)
        {
            if (string.IsNullOrEmpty(studentId))
            {
                return BadRequest("Student ID cannot be empty.");
            }

            var student = await context.Students
                                       .FirstOrDefaultAsync(s => s.Id == studentId);

            if (student == null)
            {
                return NotFound("Student not found.");
            }

            // Check if the AspNetUserRoles table is accessible through the DbContext  
            // If not, you need to add a DbSet for it in the EstigoDbContext class.  
            // Example:  
            // public DbSet<IdentityUserRole<string>> AspNetUserRoles { get; set; }  

            var userRoles = await context.Set<IdentityUserRole<string>>()
                                          .Where(ur => ur.UserId == studentId)
                                          .ToListAsync();

            if (userRoles.Any())
            {
                context.Set<IdentityUserRole<string>>().RemoveRange(userRoles);
            }

            // Delete the student  
            context.Students.Remove(student);
            await context.SaveChangesAsync();

            return Ok("Student deleted successfully.");
        }


        ////// start feature the admin for teacher
        ///////////////////////////////////////
        ////////////////////////////////////
        

        [HttpGet("AllTeacher")]
        public IActionResult GetAllTeacher()
        {
            var teachers = context.Teachers
                .Select(t => new
                {
                    t.Id,
                    t.Name,
                    t.Subject
                })
                .ToList();

            return Ok(teachers);
        }


        [HttpGet("teacher/search")]
        public async Task<IActionResult> GetTeacherDashboard([FromQuery] string query)
        {
            if (string.IsNullOrEmpty(query))
            {
                return BadRequest("Please provide a teacher name or ID.");
            }

            var teacherQuery = context.Teachers
                .Include(t => t.CoursesTaught) // Corrected to use the navigation property 'CoursesTaught'  
                .AsQueryable();

            if (int.TryParse(query, out int id))
            {
                teacherQuery = teacherQuery.Where(t => t.Id == id.ToString());
            }
            else
            {
                teacherQuery = teacherQuery.Where(t => t.Name.Contains(query));
            }

            var teacher = await teacherQuery
                .Select(t => new
                {
                    t.Id,
                    t.Name,
                    t.Gender,
                    t.Email,
                    t.PhoneNumber,
                    t.Subject,
                    t.Notes,
                    t.image,
                    Courses = t.CoursesTaught.Select(c => new // Corrected to use 'CoursesTaught'  
                    {
                        c.CourseId,
                        c.CourseTitle,
                        c.Description,
                        c.Price
                    }).ToList()
                })
                .FirstOrDefaultAsync();

            if (teacher == null)
            {
                return NotFound("Teacher not found.");
            }

            return Ok(teacher);
        }


        [HttpDelete("admin/delete-teacher/{teacherId}")]
        public async Task<ActionResult> DeleteTeacher([FromRoute] string teacherId)
        {
            if (string.IsNullOrEmpty(teacherId))
            {
                return BadRequest("Teacher ID cannot be empty.");
            }

            var teacher = await context.Teachers
                                       .FirstOrDefaultAsync(s => s.Id == teacherId);

            if (teacher == null)
            {
                return NotFound("Teacher not found.");
            }

            // Check if the AspNetUserRoles table is accessible through the DbContext  
            // If not, you need to add a DbSet for it in the EstigoDbContext class.  
            // Example:  
            // public DbSet<IdentityUserRole<string>> AspNetUserRoles { get; set; }  

            var userRoles = await context.Set<IdentityUserRole<string>>()
                                          .Where(ur => ur.UserId == teacherId)
                                          .ToListAsync();

            if (userRoles.Any())
            {
                context.Set<IdentityUserRole<string>>().RemoveRange(userRoles);
            }

            // Delete the student  
            context.Teachers.Remove(teacher);
            await context.SaveChangesAsync();

            return Ok("Teacher deleted successfully.");
        }

        /// end teacher
        /// 
        /// 
        /// start course
        [HttpGet("admin/pending-courses")]
        public async Task<IActionResult> GetPendingCourses()
        {
            try
            {
                var pendingCourses = await context.Courses
                    .Where(c => c.Status == CourseStatusEnum.Pending)
                    .Include(c => c.Teacher)
                    .ToListAsync();

                return Ok(pendingCourses);
            }
            catch (Exception ex)
            {
                // Log the exception ex
                // You can return a specific error response during debugging
                return StatusCode(500, $"An error occurred: {ex.Message} \n {ex.StackTrace}");
            }
        }

        [HttpPost("admin/approve/{id}")]
        public async Task<IActionResult> ApproveCourse(int id)
        {
            var course = await context.Courses.FindAsync(id);
            if (course == null) return NotFound();

            course.Status = CourseStatusEnum.Approved;
            course.UpdatedAt = DateTime.UtcNow;
            await context.SaveChangesAsync();

            return Ok(new { message = "Course approved successfully." });
        }


    }
}
