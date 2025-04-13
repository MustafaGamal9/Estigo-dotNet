using Estigo.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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

    }
}
