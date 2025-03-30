using Estigo.DTO;
using Estigo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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


        // Meet our instructors section
        [HttpGet("HomepageTeachers")]
        public async Task<IActionResult> GetHomepageTeachers()
        {
            var teachers = await _context.Teachers
                .Select(teacher => new TeacherHomepageDTO
                {
                    Name = teacher.Name,
                    Image = teacher.image != null ? Convert.ToBase64String(teacher.image) : null,
                    Subject = teacher.Subject
                })
                .Take(4)
                .ToListAsync();

            if (teachers == null || teachers.Count == 0)
            {
                return Ok(new List<TeacherHomepageDTO>());
            }

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