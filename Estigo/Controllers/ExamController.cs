using Estigo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Estigo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamController : ControllerBase
    {
        EstigoDbContext context;

        public ExamController(EstigoDbContext _context)
        {
            context = _context;
        }

        // GET: api/Exam/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetExamById(int id)
        {
            var exam = await context.Exams.FindAsync(id);
            if (exam == null)
                return NotFound();
            return Ok(exam);
        }



    }
}
