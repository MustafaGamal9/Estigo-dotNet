using Estigo.DTO;
using Estigo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace Estigo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly EstigoDbContext _context;

        public TeacherController(EstigoDbContext context)
        {
            _context = context;
        }


        [HttpGet("HomepageTeachers")]
        public async Task<IActionResult> GetHomepageTeachers()
        {
            var allowedNames = new List<string> { "Mahmoud", "Fahad", "Amira", "Mousa" };

            var teachers = await _context.Teachers
                .Where(teacher => allowedNames.Contains(teacher.Name))
                .Select(teacher => new TeacherHomepageDTO
                {
                    Name = teacher.Name,
                    Image = teacher.image,
                    Subject = teacher.Subject
                })
                .Take(4)
                .ToListAsync();

            return Ok(teachers);
        }


        [HttpGet]
        public IActionResult GetAllCourses()
        {
            var teachers = _context.Teachers
                .Select(t => new
                {
                    t.Id,
                    t.Name,
                    t.Subject,
                    ImageUrl = Url.Action("GetTeacherImage", "Teacher", new { id = t.Id }, Request.Scheme)
                })
                .ToList();

            return Ok(teachers);
        }

    }
}