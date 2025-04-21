using Estigo.DTO;
using Estigo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using Estigo.Migrations;
using Estigo.Enums;
using static Estigo.Enums.CourseStatus;

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

        [HttpPost("add")]
        public async Task<IActionResult> TeacherAddCourse([FromBody] courseDTO dto)
        {
            var course = new Course
            {
                CourseTitle = dto.CourseTitle,
                Description = dto.Description,
                Logo = dto.Logo,
                Price = dto.Price,
                Available = dto.Available,
                CategoryId = dto.catogryid,
                TeacherId = dto.TeacherId,
                Status = CourseStatusEnum.Pending,
                CreatedAt = DateTime.UtcNow
            };

            _context.Courses.Add(course);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Course submitted for admin approval." });
        }

        [HttpGet("teacher-courses")]
        public async Task<IActionResult> GetCoursesByTeacher([FromQuery] string teacherId)
        {
            try
            {
                var courses = await _context.Courses
                    .Where(c => c.TeacherId == teacherId)
                    .Select(c => new { c.CourseId, c.CourseTitle })
                    .ToListAsync();

                return Ok(courses);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message} \n {ex.StackTrace}");
            }
        }

        [HttpGet("teacher-lessons")]
        public async Task<IActionResult> GetLessonsByTeacher([FromQuery] string teacherId)
        {
            try
            {
                var lessons = await _context.lessons
                    .Where(l => l.Course.TeacherId == teacherId)
                    .Select(l => new
                    {
                        LessonId = l.lessonId,
                        LessonTitle = l.lessonTitle,
                    })
                    .ToListAsync();

                return Ok(lessons);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}\n{ex.StackTrace}");
            }
        }



        [HttpGet("{teacherId}")]
        public IActionResult GetLessonsByTeacherId(string teacherId)
        {
            var lessons = _context.lessons
                .Where(l => l.Course.TeacherId == teacherId)
                .Select(l => new
                {
                    l.lessonId,
                    l.lessonTitle
                })
                .ToList();

            return Ok(lessons);
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
        [HttpPost("add-exam")]
        public async Task<IActionResult> AddExam([FromBody] ExamDTO examDto)
        {
            if (examDto == null || examDto.Questions == null || !examDto.Questions.Any())
                return BadRequest("Exam and questions are required.");

            var exam = new Exam
            {
                ExamTitle = examDto.ExamTitle,
                ExamDescription = examDto.ExamDescription,
                Grade = examDto.Grade,
                lessonId = examDto.lessonId,
                Questions = examDto.Questions.Select(q => new BankOfQuestion
                {
                    QuestionText = q.QuestionText,
                    OptionA = q.OptionA,
                    OptionB = q.OptionB,
                    OptionC = q.OptionC,
                    OptionD = q.OptionD,
                    CorrectAnswer = q.CorrectAnswer
                }).ToList()
            };

            _context.Exams.Add(exam);
            await _context.SaveChangesAsync();

            return Ok(new { ExamId = exam.Id, Message = "Exam created successfully." });
        }
    }
}