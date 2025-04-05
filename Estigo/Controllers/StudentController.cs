using Microsoft.AspNetCore.Mvc;
using Estigo.Models;
using Microsoft.AspNetCore.Identity; 
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization; 
using System.Linq; 
using System; 
using System.Collections.Generic;


namespace Estigo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly EstigoDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;


        public StudentController(
            EstigoDbContext context,
            UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;

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
                .AnyAsync(mc => mc.StudentId == studentId && mc.CourseId == courseId);

            if (alreadyEnrolled)
            {
                return BadRequest(new { message = "already enrolled in this course." });
            }

            var payment = new Payment
            {
                StudentId = studentId,
                CourseId = courseId,
                PurchaseDate = DateTime.UtcNow,
                PaymentMethod = "Card Kda w Kda"
            };

            var enrollment = new MyCourse
            {
                StudentId = studentId,
                CourseId = courseId,
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
                    enrollmentId = enrollment.MyCourseId,
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
                    mc.Course.CourseId,
                    mc.Course.CourseTitle,
                    mc.Course.Description,
                    ImageBase64 = mc.Course.Logo != null ? Convert.ToBase64String(mc.Course.Logo) : null,
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