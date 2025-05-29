using Estigo.DTO;
using Estigo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
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
                    isLive = l.isLive,
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


        // My course page
        [HttpGet("GetCourseDetails/{courseId}/{userId}")]
        public async Task<IActionResult> GetCourseDetails(int courseId, string userId)
        {
            // Validate user ID  
            if (string.IsNullOrEmpty(userId))
            {
                return BadRequest("User ID is required to track attendance.");
            }

            // Check if the user is an admin  
            var isAdmin = await context.Admins.AnyAsync(a => a.Id == userId);
            if (isAdmin)
            {
                // Admin is allowed directly  
                var lessonsForAdmin = context.lessons
                    .Include(l => l.Exam)
                    .Where(l => l.courseId == courseId)
                    .Select(l => new
                    {
                        l.lessonTitle,
                        l.lessonVideo,
                        ExamTitle = l.Exam != null ? l.Exam.ExamTitle : null,
                        ExamId = l.Exam != null ? l.Exam.Id : (int?)null,
                        l.isLive
                    })
                    .ToList();

                if (lessonsForAdmin == null || !lessonsForAdmin.Any())
                {
                    return NotFound($"No lessons found for course ID {courseId}.");
                }

                return Ok(lessonsForAdmin);
            }

            // Check if the user is a student  
            var isStudent = await context.Students.AnyAsync(s => s.Id == userId);
            if (!isStudent)
            {
                return BadRequest("User is neither an admin nor a student.");
            }

            // Get lessons for the course  
            var lessons = context.lessons
                .Include(l => l.Exam)
                .Where(l => l.courseId == courseId)
                .Select(l => new
                {
                    l.lessonTitle,
                    l.lessonVideo,
                    ExamTitle = l.Exam != null ? l.Exam.ExamTitle : null,
                    ExamId = l.Exam != null ? l.Exam.Id : (int?)null,
                    l.isLive
                })
                .ToList();

            if (lessons == null || !lessons.Any())
            {
                return NotFound($"No lessons found for course ID {courseId}.");
            }

            // Update attendance for this student and course  
            var myCourse = await context.MyCourses
                .FirstOrDefaultAsync(mc => mc.StudentId == userId && mc.courseId == courseId);

            if (myCourse != null)
            {
                // Increment attendance (max value is 1 per course)  
                if (myCourse.attendance < 1)
                {
                    myCourse.attendance = 1;
                    await context.SaveChangesAsync();
                }
            }
            else
            {
                // Student is not enrolled in this course  
                return BadRequest("Student is not enrolled in this course.");
            }

            return Ok(lessons);
        }

        // Get student attendance rate
        [HttpGet("GetAttendanceRate/{studentId}")]
        public async Task<IActionResult> GetAttendanceRate(string studentId)
        {
            // Validate student ID
            if (string.IsNullOrEmpty(studentId))
            {
                return BadRequest("Student ID is required.");
            }

            // Check if student exists
            var studentExists = await context.Students.AnyAsync(s => s.Id == studentId);
            if (!studentExists)
            {
                return NotFound($"Student with ID {studentId} not found.");
            }

            // Get all courses the student is enrolled in
            var enrolledCourses = await context.MyCourses
                .Where(mc => mc.StudentId == studentId)
                .ToListAsync();

            if (!enrolledCourses.Any())
            {
                return Ok(new { attendanceRate = 0, message = "Student is not enrolled in any courses." });
            }

            // Calculate attendance rate
            int totalCourses = enrolledCourses.Count;
            int attendedCourses = enrolledCourses.Sum(c => c.attendance);
            double attendanceRate = (double)attendedCourses / totalCourses * 100;

            return Ok(new { attendanceRate = Math.Round(attendanceRate, 2) });
        }


        
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

        [HttpPost]
        public async Task<IActionResult> CreateLesson([FromBody] LessonDTO lessonDto)
        {
            var debugInfo = new List<string>();

            try
            {
                debugInfo.Add($"=== DETAILED DEBUG ===");
                debugInfo.Add($"DTO isLive received: {lessonDto?.isLive}");
                debugInfo.Add($"DTO full object: {System.Text.Json.JsonSerializer.Serialize(lessonDto)}");

                if (lessonDto == null)
                {
                    debugInfo.Add("LessonDTO is null!");
                    return BadRequest(new { error = "Invalid lesson data.", debug = debugInfo });
                }

                // Create the lesson entity
                var lesson = new lesson
                {
                    lessonTitle = lessonDto.lessonTitle,
                    lessonDescription = lessonDto.lessonDescription,
                    lessonContent = lessonDto.lessonContent,
                    lessonVideo = lessonDto.lessonVideo,
                    isLive = lessonDto.isLive,
                    courseId = lessonDto.courseId,
                    CreatedAt = DateTime.UtcNow
                };

                debugInfo.Add($"Lesson entity isLive BEFORE adding to context: {lesson.isLive}");

                // Add to context but don't save yet
                context.lessons.Add(lesson);

                debugInfo.Add($"Lesson entity isLive AFTER adding to context: {lesson.isLive}");

                // Check the entity state
                var entry = context.Entry(lesson);
                debugInfo.Add($"Entity state: {entry.State}");
                debugInfo.Add($"isLive property current value: {entry.CurrentValues["isLive"]}");

                // Save changes
                await context.SaveChangesAsync();

                debugInfo.Add($"Lesson entity isLive AFTER SaveChanges: {lesson.isLive}");

                // Re-fetch from database to confirm
                var savedLesson = await context.lessons.FindAsync(lesson.lessonId);
                debugInfo.Add($"Re-fetched lesson isLive: {savedLesson?.isLive}");

                // Write debug info to file
                var debugText = string.Join(Environment.NewLine, debugInfo);
                await System.IO.File.WriteAllTextAsync("debug_lesson.txt", debugText);

                return Ok(new
                {
                    lesson = lesson,
                    debugInfo = debugInfo  // This will show in your API response
                });
            }
            catch (Exception ex)
            {
                debugInfo.Add($"ERROR: {ex.Message}");
                debugInfo.Add($"STACK TRACE: {ex.StackTrace}");

                // Write error to file
                var errorText = string.Join(Environment.NewLine, debugInfo);
                await System.IO.File.WriteAllTextAsync("debug_lesson_error.txt", errorText);

                return StatusCode(500, new { error = ex.Message, debug = debugInfo });
            }
        }



        // PATCH: api/lesson/{id}
        [HttpPatch("{id}")]
        [Consumes("application/json-patch+json")]

        public async Task<IActionResult> PatchLesson(int id, [FromBody] JsonPatchDocument<LessonDTO> patchDoc)
        {
            if (patchDoc == null)
                return BadRequest("Invalid patch data.");

            var lessonEntity = await context.lessons.FindAsync(id); // Use your DbSet name
            if (lessonEntity == null)
                return NotFound();

            // Create a DTO to apply the patch to
            var lessonDto = new LessonDTO
            {
                lessonTitle = lessonEntity.lessonTitle,
                lessonDescription = lessonEntity.lessonDescription,
                lessonContent = lessonEntity.lessonContent,
                lessonVideo = lessonEntity.lessonVideo,
                courseId = lessonEntity.courseId
            };

            // Apply patch and validate
            patchDoc.ApplyTo(lessonDto);

            TryValidateModel(lessonDto); // Validate the DTO *after* patching

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            // Map changes from DTO back to entity
            lessonEntity.lessonTitle = lessonDto.lessonTitle;
            lessonEntity.lessonDescription = lessonDto.lessonDescription;
            lessonEntity.lessonContent = lessonDto.lessonContent;
            lessonEntity.lessonVideo = lessonDto.lessonVideo;
            lessonEntity.courseId = lessonDto.courseId;
            // lessonEntity.UpdatedAt = DateTime.UtcNow; // Optional

            await context.SaveChangesAsync();

            return NoContent(); // Success, no content to return
        }

        // DELETE: api/lesson/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLesson(int id)
        {
            var lessonToDelete = await context.lessons.FindAsync(id); // Use your DbSet name
            if (lessonToDelete == null)
                return NotFound();

            context.lessons.Remove(lessonToDelete);
            await context.SaveChangesAsync();

            return NoContent(); // Success, no content to return
        }
    }

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

