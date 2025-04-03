using Estigo.DTO;

using Estigo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using lesson = Estigo.Models.lesson;

namespace Estigo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LessonController : ControllerBase
    {
        EstigoDbContext context;
        public LessonController(EstigoDbContext _context)
        {
            context = _context;
        }

        // ... other code ...
        [HttpGet("GetCourseByLessonName/{lessonName}")]
        public async Task<IActionResult> GetCourseByLessonName(string lessonName)
        {
            var course = await context.lessons
                .Where(c => c.lessonTitle == lessonName)
                .Include(c => c.Course)  
                .Select(c => new
                {
                    CourseName = c.Course.CourseTitle
                })
                .FirstOrDefaultAsync();

            if (course == null)
            {
                return NotFound(new { message = "Course not found" });
            }

            return Ok(course.CourseName);
        }


        // GET: api/Lesson/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetLessonById(int id)
        {
            var lesson = await context.lessons.FindAsync(id);
            if (lesson == null)
                return NotFound();

            return Ok(lesson);
        }

        // POST: api/lesson
        [HttpPost]
        public async Task<IActionResult> CreateLesson([FromBody] LessonDTO lessonDto)
        {
            if (lessonDto == null)
                return BadRequest("Invalid chapter data.");

            var lesson = new lesson
            {
                lessonTitle = lessonDto.lessonTitle,
                lessonDescription = lessonDto.lessonDescription,
                lessonContent = lessonDto.lessonContent,
                lessonVideo = lessonDto.lessonVideo,
                courseId = lessonDto.courseId,
                CreatedAt = DateTime.UtcNow
            };

            context.lessons.Add(lesson);
            await context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetLessonById), new { id = lesson.lessonId }, lesson);
        }

        // PUT: api/lesson/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateLesson(int id, [FromBody] LessonDTO lessonDTO)
        {
            if (id != lessonDTO.lessonId)
                return BadRequest("Lesson ID mismatch.");

            var existingLesson = await context.lessons.FindAsync(id);
            if (existingLesson == null)
                return NotFound("Lesson not found.");

            existingLesson.lessonTitle = lessonDTO.lessonTitle;
            existingLesson.lessonDescription = lessonDTO.lessonDescription;
            existingLesson.lessonContent = lessonDTO.lessonContent;
            existingLesson.lessonVideo = lessonDTO.lessonVideo;
            existingLesson.courseId = lessonDTO.courseId;
            existingLesson.UpdatedAt = DateTime.UtcNow;

            context.lessons.Update(existingLesson);
            await context.SaveChangesAsync();

            return Ok(existingLesson);
        }

        // DELETE: api/lesson/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLesson(int id)
        {
            var lesson = await context.lessons.FindAsync(id);
            if (lesson == null)
                return NotFound("Lesson not found.");

            context.lessons.Remove(lesson);
            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpGet("GetCourseLessons")]
        public async Task<ActionResult<IEnumerable<LessonDTO>>> GetCourseLessons(int courseId)
        {
            var lessons = await context.lessons
                .Where(c => c.courseId == courseId)
                .Select(c => new LessonDTO
                {
                    lessonId = c.lessonId,
                    lessonTitle = c.lessonTitle,
                    lessonDescription = c.lessonDescription,
                    lessonContent = c.lessonContent,
                    CreatedAt = c.CreatedAt,
                    UpdatedAt = c.UpdatedAt,
                    courseId = c.courseId
                }).ToListAsync();
            return Ok(lessons);
        }
    }
}
