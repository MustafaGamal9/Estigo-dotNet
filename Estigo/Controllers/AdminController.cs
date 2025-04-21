using Estigo.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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

        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
            return Ok();

        }

        [HttpPut]
        public IActionResult EditStudent(Student student)
        {
            context.Students.Update(student);
            context.SaveChanges();
            return Ok();
        }

        [HttpDelete("{studentId}")]
        public ActionResult DeleteStudent([FromRoute] int studentId)
        {
            var student = context.Students.Find(studentId);
            if (student == null)
            {
                return NotFound("Student Not Found!!!!!!");
            }

            context.Students.Remove(student);
            context.SaveChanges();
            return Ok("Student Deleted Successfully");
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
