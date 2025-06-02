using Microsoft.AspNetCore.Mvc;
using Estigo.Models;
using Microsoft.AspNetCore.Identity; 
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization; 
using System.Linq; 
using System; 
using System.Collections.Generic;
using System.Net.Http;
using Estigo.DTO;


namespace Estigo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly EstigoDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        private readonly HttpClient _httpClient;

        public StudentController(
            EstigoDbContext context,
            UserManager<ApplicationUser> userManager,
            IHttpClientFactory httpClientFactory)  
        {
            _context = context;
            _userManager = userManager;
            _httpClient = httpClientFactory.CreateClient(); 
        }



        [HttpPost("{studentId}/enroll/{courseId}")]

        public async Task<IActionResult> EnrollCourse(string studentId, int courseId)
        {

            var student = await _userManager.FindByIdAsync(studentId);

            if (student == null || student.Role != Roles.Student)
            {
                return NotFound(new { message = "Student not found or user is not a student." });
            }

            var course = await _context.Courses.FindAsync(courseId);
            if (course == null)
            {
                return NotFound(new { message = "Course not found." });
            }

            if (!course.Available)
            {
                return BadRequest(new { message = "This course is currently not available for enrollment." });
            }


            bool alreadyEnrolled = await _context.MyCourses
                .AnyAsync(mc => mc.StudentId == studentId && mc.courseId == courseId);

            if (alreadyEnrolled)
            {
                return BadRequest(new { message = "already enrolled in this course." });
            }

            var payment = new Payment
            {
                StudentId = studentId,
                courseId = courseId,
                PurchaseDate = DateTime.UtcNow,
                PaymentMethod = "Fawry"
            };

            var enrollment = new MyCourse
            {
                StudentId = studentId,
                courseId = courseId,
                EnrollmentDate = DateTime.UtcNow
            };


            try
            {
                _context.Payments.Add(payment);
                _context.MyCourses.Add(enrollment);
                await _context.SaveChangesAsync();


                return Ok(new
                {
                    message = "Enrollment successful",
                    enrollmentId = enrollment.MycourseId,
                    paymentId = payment.PaymentId,
                    courseTitle = course.CourseTitle,
                    enrollmentDate = enrollment.EnrollmentDate
                });
            }
            catch (DbUpdateException ex)
            {

                Console.WriteLine($"Error saving enrollment for Student ID {studentId} / Course ID {courseId}: {ex.ToString()}");

                return StatusCode(500, new { message = "An internal error occurred while processing the enrollment. Please try again later." });
            }
        }

        [HttpPost("SetTeacherImage")]
        public async Task<IActionResult> SetTeacherImage(string teacherId, string imagePath)
        {
            var teacher = await _userManager.Users
                .OfType<Teacher>()
                .FirstOrDefaultAsync(t => t.Id == teacherId);

            if (teacher == null)
                return NotFound("Teacher not found.");

            teacher.image = imagePath;
            var result = await _userManager.UpdateAsync(teacher);

            if (!result.Succeeded)
                return BadRequest(result.Errors);

            return Ok("Teacher image updated.");
        }




        [HttpGet("{studentId}/mycourses")]

        public async Task<IActionResult> GetMyCourses(string studentId)
        {
            var student = await _userManager.FindByIdAsync(studentId);
            if (student == null || student.Role != Roles.Student)
            {
                return NotFound(new { message = "Student not found or user is not a student." });
            }

            var enrolledCourses = await _context.MyCourses
                .Where(mc => mc.StudentId == studentId)
                .Include(mc => mc.Course)
                .ThenInclude(c => c.Teacher)
                .OrderByDescending(mc => mc.EnrollmentDate)
                .Select(mc => new
                {
                    mc.Course.courseId,
                    mc.Course.CourseTitle,
                    mc.Course.Description,
                    ImageBase64 = mc.Course.Logo,
                    TeacherName = mc.Course.Teacher != null ? mc.Course.Teacher.Name : "N/A",
                    mc.EnrollmentDate,
                    mc.Course.Price

                })
                .ToListAsync();

            return Ok(enrolledCourses);
        }

        [HttpGet("{studentId}/mypayment")]
        public async Task<IActionResult> GetMyPayment(string studentId)
        {
            var student = await _userManager.FindByIdAsync(studentId);
            if (student == null || student.Role != Roles.Student)
            {
                return NotFound(new { message = "Student not found or user is not a student." });
            }
            var payments = await _context.Payments
                .Where(p => p.StudentId == studentId)
                .Include(p => p.Course)
                .OrderByDescending(p => p.PurchaseDate)
                .Take(4)
                .Select(p => new
                {
                    p.PaymentId,
                    p.PurchaseDate,
                    p.PaymentMethod,
                    CourseTitle = p.Course.CourseTitle,
                    CoursePrice = p.Course.Price
                })
                .ToListAsync();
            return Ok(payments);
        }

       
    }
}
