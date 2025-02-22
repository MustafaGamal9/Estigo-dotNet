using Estigo.DTO;
using Estigo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Estigo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChapterController : ControllerBase
    {
        EstigoDbContext context;
        public ChapterController(EstigoDbContext _context)
        {
            context = _context;
        }


        [HttpGet("GetChaptersByCourseName/{courseName}")]
        public async Task<IActionResult> GetChaptersByCourseName(string courseName)
        {
            var course = await context.Courses
                .Where(c => c.CourseTitle == courseName)
                .Select(c => new
                {
                    c.CourseId,
                    c.CourseTitle,
                    Chapters = c.Chapters.Select(ch => new
                    {
                        ch.ChapterId,
                        ch.ChapterTitle,
                        ch.Description
                    }).ToList()
                })
                .FirstOrDefaultAsync();

            if (course == null)
            {
                return NotFound(new { message = "Course not found" });
            }

            return Ok(course.Chapters);
        }

        // GET: api/Chapters/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetChapterById(int id)
        {
            var chapter = await context.Chapters.FindAsync(id);
            if (chapter == null)
                return NotFound();

            return Ok(chapter);
        }

        // POST: api/Chapters
        [HttpPost]
        public async Task<IActionResult> CreateChapter([FromBody] ChapterDTO chapterDto)
        {
            if (chapterDto == null)
                return BadRequest("Invalid chapter data.");

            var chapter = new Chapter
            {
                ChapterTitle = chapterDto.ChapterTitle,
                Description = chapterDto.Description,
                CourseId = chapterDto.CourseId,
                CreatedAt = DateTime.UtcNow
            };

            context.Chapters.Add(chapter);
            await context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetChapterById), new { id = chapter.ChapterId }, chapter);
        }

        // PUT: api/Chapters/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateChapter(int id, [FromBody] Chapter chapter)
        {
            if (id != chapter.ChapterId)
                return BadRequest("Chapter ID mismatch.");

            var existingChapter = await context.Chapters.FindAsync(id);
            if (existingChapter == null)
                return NotFound("Chapter not found.");

            existingChapter.ChapterTitle = chapter.ChapterTitle;
            existingChapter.Description = chapter.Description;
            existingChapter.CourseId = chapter.CourseId; // Ensure course association is maintained

            context.Chapters.Update(existingChapter);
            await context.SaveChangesAsync();

            return Ok(existingChapter);
        }

        // DELETE: api/Chapters/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChapter(int id)
        {
            var chapter = await context.Chapters.FindAsync(id);
            if (chapter == null)
                return NotFound("Chapter not found.");

            context.Chapters.Remove(chapter);
            await context.SaveChangesAsync();
            return NoContent();
        }

    }
}
