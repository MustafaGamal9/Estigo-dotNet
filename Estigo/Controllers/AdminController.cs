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
            var students = context.Students
                .Select(s => new { s.Id, s.Name, s.Email })
                .ToList();

            return Ok(students);
        }


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
        [HttpGet("AllParents")]
        public IActionResult GetAllParent()
        {
            var teachers = context.Parents
                .Select(t => new
                {
                    t.Id,
                    t.Name
                })
                .ToList();

            return Ok(teachers);
        }

        //[HttpGet("student/search")]
        //public async Task<ActionResult<DashboardDTO>> GetStudentDashboard([FromQuery] string query)
        //{
        //    // التحقق من أن المستخدم أدخل استعلام
        //    if (string.IsNullOrEmpty(query))
        //    {
        //        return BadRequest("Please provide a student name or code.");
        //    }

        //    // تجهيز الاستعلام
        //    var studentQuery = context.Students.AsQueryable();

        //    // محاولة تحويل الاستعلام إلى كود
        //    if (int.TryParse(query, out int code))
        //    {
        //        studentQuery = studentQuery.Where(s => s.StudentCode == code);
        //    }
        //    else
        //    {
        //        studentQuery = studentQuery.Where(s => s.Name.Contains(query));
        //    }

        //    // الحصول على الطالب
        //    var student = await studentQuery.FirstOrDefaultAsync();

        //    if (student == null)
        //    {
        //        return NotFound("Student not found.");
        //    }

        //    string studentId = student.Id;

        //    // --- الكورسات المسجل فيها الطالب ---
        //    var enrolledCourses = await context.MyCourses
        //        .Where(mc => mc.StudentId == studentId)
        //        .Include(mc => mc.Course)
        //        .Select(mc => mc.Course)
        //        .Where(c => c != null)
        //        .OrderBy(c => c.CourseTitle)
        //        .Take(3)
        //        .Select(c => new EnrolledCourseDTO
        //        {
        //            courseId = c.courseId,
        //            CourseName = c.CourseTitle,
        //            CourseImageUrl = c.Logo
        //        })
        //        .ToListAsync();

        //    // --- المدرسين ---
        //    var courseInstructors = await context.MyCourses
        //        .Where(mc => mc.StudentId == studentId)
        //        .Include(mc => mc.Course)
        //            .ThenInclude(c => c.Teacher)
        //        .Select(mc => mc.Course.Teacher)
        //        .Distinct()
        //        .Take(3)
        //        .Select(t => new InstructorImageDTO
        //        {
        //            InstructorImageUrl = t.image
        //        })
        //        .ToListAsync();

        //    // --- اختبارات الكورسات ---
        //    var enrolledcourseIds = await context.MyCourses
        //        .Where(mc => mc.StudentId == studentId)
        //        .Select(mc => mc.courseId)
        //        .Distinct()
        //        .ToListAsync();

        //    var lessonIds = await context.lessons
        //        .Where(l => enrolledcourseIds.Contains(l.courseId))
        //        .Select(l => l.lessonId)
        //        .ToListAsync();

        //    var quizzes = await context.Exams
        //        .Where(q => lessonIds.Contains(q.lessonId))
        //        .Take(2)
        //        .Select(q => new QuizInfoDTO
        //        {
        //            QuizId = q.Id,
        //            QuizName = q.ExamTitle
        //        })
        //        .ToListAsync();

        //    // --- الدفع ---
        //    var paymentInfo = await context.Payments
        //        .Where(p => p.StudentId == studentId)
        //        .Take(2)
        //        .Select(p => new PaymentInfoDTO
        //        {
        //            PurchaseDate = p.PurchaseDate,
        //            CourseTitle = p.Course.CourseTitle
        //        })
        //        .ToListAsync();

        //    // --- تجميع البيانات ---
        //    var dashboardData = new
        //    {
        //        StudentId = student.Id,
        //        StudentName = student.Name,
        //        StudentCode = student.StudentCode.ToString(),
        //        EnrolledCourses = enrolledCourses,
        //        CourseInstructors = courseInstructors,
        //        Quizzes = quizzes,
        //        PaymentInfo = paymentInfo
        //    };

        //    return Ok(dashboardData);
        //}


        [HttpDelete("User/{userId}")]
        public async Task<ActionResult> DeleteUser([FromRoute] string userId)
        {
            if (string.IsNullOrEmpty(userId))
            {
                return BadRequest("User ID cannot be empty.");
            }

            try
            {
                // Try to find the user in Students, Parents, or Teachers table
                var student = await context.Students.FirstOrDefaultAsync(s => s.Id == userId);
                var parent = await context.Parents.FirstOrDefaultAsync(p => p.Id == userId);
                var teacher = await context.Teachers.FirstOrDefaultAsync(t => t.Id == userId);

                if (student == null && parent == null && teacher == null)
                {
                    return NotFound("User not found.");
                }

                // Delete any roles associated with the user
                var userRoles = await context.Set<IdentityUserRole<string>>()
                    .Where(ur => ur.UserId == userId)
                    .ToListAsync();

                if (userRoles.Any())
                {
                    context.Set<IdentityUserRole<string>>().RemoveRange(userRoles);
                }

                // Remove the user from the appropriate table
                if (student != null)
                {
                    context.Students.Remove(student);
                }
                else if (parent != null)
                {
                    context.Parents.Remove(parent);
                }
                else if (teacher != null)
                {
                    context.Teachers.Remove(teacher);
                }

                await context.SaveChangesAsync();
                return Ok("User deleted successfully.");
            }
            catch (Exception ex)
            {
                // Log the exception
                Console.WriteLine($"Error occurred while deleting user: {ex.Message}");
                return StatusCode(500, "An error occurred while deleting the user.");
            }
        }

        



        //[HttpGet("teacher/search")]
        //public async Task<IActionResult> GetTeacherDashboard([FromQuery] string query)
        //{
        //    if (string.IsNullOrEmpty(query))
        //    {
        //        return BadRequest("Please provide a teacher name or ID.");
        //    }

        //    var teacherQuery = context.Teachers
        //        .Include(t => t.CoursesTaught) // Corrected to use the navigation property 'CoursesTaught'  
        //        .AsQueryable();

        //    if (int.TryParse(query, out int id))
        //    {
        //        teacherQuery = teacherQuery.Where(t => t.Id == id.ToString());
        //    }
        //    else
        //    {
        //        teacherQuery = teacherQuery.Where(t => t.Name.Contains(query));
        //    }

        //    var teacher = await teacherQuery
        //        .Select(t => new
        //        {
        //            t.Id,
        //            t.Name,
        //            t.Gender,
        //            t.Email,
        //            t.PhoneNumber,
        //            t.Subject,
        //            t.Notes,
        //            t.image,
        //            Courses = t.CoursesTaught.Select(c => new // Corrected to use 'CoursesTaught'  
        //            {
        //                c.courseId,
        //                c.CourseTitle,
        //                c.Description,
        //                c.Price
        //            }).ToList()
        //        })
        //        .FirstOrDefaultAsync();

        //    if (teacher == null)
        //    {
        //        return NotFound("Teacher not found.");
        //    }

        //    return Ok(teacher);
        //}




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
                    .Select(c => new
                    {
                        c.courseId,
                        c.CourseTitle,
                        c.Logo,
                        c.Price,
                        c.TeacherId,
                        c.Teacher.Name
                    })
                    .ToListAsync();

                return Ok(pendingCourses);
            }
            catch (Exception ex)
            {
                // Log the exception ex
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
