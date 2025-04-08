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

        [HttpGet("GetAllLessons")]
        public IActionResult GetAllLessons()
        {
            var lessons = context.lessons
                .Select(l => new LessonDTO
                {
                    lessonId = l.lessonId,
                    lessonTitle = l.lessonTitle,
                    lessonDescription = l.lessonDescription,
                    lessonContent = l.lessonContent,
                    lessonVideo = l.lessonVideo,
                    courseId = l.courseId
                })
                .ToList();
            return Ok(lessons);
        }

        // return lessonDetails by courseId
        [HttpGet("GetLessonDetails/{lessonId}")]
        public IActionResult GetLessonDetails(int lessonId)
        {
            var lessonWithExam = context.lessons
                .Where(l => l.lessonId == lessonId)
                .Select(l => new LessonExamDTO
                {
                    lessonTitle = l.lessonTitle,
                    lessonDescription = l.lessonDescription,
                    lessonContent = l.lessonContent,
                    lessonVideo = l.lessonVideo,
                    examTitle = l.Exam != null ? l.Exam.ExamTitle : null,
                })
                .FirstOrDefault();

            if (lessonWithExam == null)
            {
                return NotFound("Lesson not found.");
            }

            return Ok(lessonWithExam);
        }


        // Returns lesson details by courseId
        [HttpGet("GetCourseDetails/{courseId}")]
        public IActionResult GetCourseDetails(int courseId)
        {
            var lessons = context.lessons
                .Include(l => l.Exam)
                .Where(l => l.courseId == courseId)
                .Select(l => new
                {
                    l.lessonTitle,
                    l.lessonVideo,
                    ExamTitle = l.Exam != null ? l.Exam.ExamTitle : null,
                    ExamId = l.Exam != null ? l.Exam.Id : (int?)null
                })
                .ToList();

            if (lessons == null || !lessons.Any())
            {
                return NotFound($"No lessons found for course ID {courseId}.");
            }

            return Ok(lessons);
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

        [HttpGet("GetByLessonName/{lessonName}")]
        public async Task<IActionResult> GetByLessonName(string lessonName)
        {
            var lesson = await context.lessons
                .Include(c=> c.Exam)
                .Where(c => c.lessonTitle == lessonName)
                .Select(c => new
                {
                    LessonName = c.lessonTitle,
                    LessonVideo = c.lessonVideo,
                    lessonExam = c.Exam.ExamTitle

                })
                .FirstOrDefaultAsync();

            if (lesson == null)
            {
                return NotFound(new { message = "Course not found" });
            }

            return Ok(lesson);
        }

        //// POST: api/lesson
        //[HttpPost]
        //public async Task<IActionResult> CreateLesson([FromBody] LessonDTO lessonDto)
        //{
        //    if (lessonDto == null)
        //        return BadRequest("Invalid chapter data.");

        //    var lesson = new lesson
        //    {
        //        lessonTitle = lessonDto.lessonTitle,
        //        lessonDescription = lessonDto.lessonDescription,
        //        lessonContent = lessonDto.lessonContent,
        //        lessonVideo = lessonDto.lessonVideo,
        //        courseId = lessonDto.courseId,
        //        CreatedAt = DateTime.UtcNow
        //    };

        //    context.lessons.Add(lesson);
        //    await context.SaveChangesAsync();
        //    return CreatedAtAction(nameof(GetLessonById), new { id = lesson.lessonId }, lesson);
        //}

        //// PUT: api/lesson/{id}
        //[HttpPut("{id}")]
        //public async Task<IActionResult> UpdateLesson(int id, [FromBody] LessonDTO lessonDTO)
        //{
        //    if (id != lessonDTO.lessonId)
        //        return BadRequest("Lesson ID mismatch.");

        //    var existingLesson = await context.lessons.FindAsync(id);
        //    if (existingLesson == null)
        //        return NotFound("Lesson not found.");

        //    existingLesson.lessonTitle = lessonDTO.lessonTitle;
        //    existingLesson.lessonDescription = lessonDTO.lessonDescription;
        //    existingLesson.lessonContent = lessonDTO.lessonContent;
        //    existingLesson.lessonVideo = lessonDTO.lessonVideo;
        //    existingLesson.courseId = lessonDTO.courseId;
        //    existingLesson.UpdatedAt = DateTime.UtcNow;

        //    context.lessons.Update(existingLesson);
        //    await context.SaveChangesAsync();

        //    return Ok(existingLesson);
        //}

        //// DELETE: api/lesson/{id}
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteLesson(int id)
        //{
        //    var lesson = await context.lessons.FindAsync(id);
        //    if (lesson == null)
        //        return NotFound("Lesson not found.");

        //    context.lessons.Remove(lesson);
        //    await context.SaveChangesAsync();
        //    return NoContent();
        //}

        //[HttpGet("GetCourseLessons")]
        //public async Task<ActionResult<IEnumerable<LessonDTO>>> GetCourseLessons(int courseId)
        //{
        //    var lessons = await context.lessons
        //        .Where(c => c.courseId == courseId)
        //        .Select(c => new LessonDTO
        //        {
        //            lessonId = c.lessonId,
        //            lessonTitle = c.lessonTitle,
        //            lessonDescription = c.lessonDescription,
        //            lessonContent = c.lessonContent,
        //            CreatedAt = c.CreatedAt,
        //            UpdatedAt = c.UpdatedAt,
        //            courseId = c.courseId
        //        }).ToListAsync();
        //    return Ok(lessons);
        //}
    }
}
