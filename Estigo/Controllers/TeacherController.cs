using Estigo.DTO;
using Estigo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

    [HttpGet("{teacherId}/students")]
    public async Task<IActionResult> GetStudentsByTeacher(string teacherId)
    {
            var students = await _context.Courses
                .Where(c => c.TeacherId == teacherId)
                .Join(_context.MyCourses,
                    course => course.courseId,
                    myCourse => myCourse.courseId,
                    (course, myCourse) => new {
                        Student = myCourse.Student,
                        CategoryId = course.CategoryId
                    })
                .Select(x => new {
                    x.Student.Id,
                    x.Student.Name,
                    x.CategoryId
                })
                .Distinct()
                .ToListAsync();


            if (!students.Any())
            return NotFound("No students found for this teacher");

        return Ok(students);
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

        [HttpPost("add-course")]
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
                    .Select(c => new { c.courseId, c.CourseTitle })
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
                final = examDto.final,
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

        [HttpGet("QuizResults/{quizId}")]
        public async Task<IActionResult> GetQuizResults(int quizId)
        {
            var results = await _context.StudentExamResults
                .Where(r => r.ExamId == quizId)
                .Include(r => r.Answers)
                .Select(r => new
                {
                    StudentId = r.StudentId,
                    StudentName = _context.Users.FirstOrDefault(u => u.Id == r.StudentId).UserName,
                    Score = r.Score,
                    TotalQuestions = r.Answers.Count, // Fix: Replace 'CorrectAnswers' with 'Answers.Count'  
                    DateTaken = r.ExamDate
                })
                .ToListAsync();

            return Ok(results);
        }


        [HttpGet("exam/{examId}/student/{studentId}/answers")]
        public async Task<IActionResult> GetStudentAnswersOnly(int examId, string studentId)
        {
            var result = await _context.StudentExamResults
                .Where(r => r.ExamId == examId && r.StudentId == studentId)
                .Include(r => r.Answers)
                .Include(r => r.Student)
                .FirstOrDefaultAsync();

            if (result == null)
                return NotFound("No result found for this student and exam.");

            var response = new
            {
                StudentId = result.Student.Id,
                StudentName = result.Student.Name, 
                Score = result.Score,
                ExamDate = result.ExamDate,
                Answers = result.Answers.Select(a => new
                {
                    a.QuestionId,
                    a.SelectedOption,
                    a.IsCorrect
                }).ToList()
            };

            return Ok(response);
        }


    }
}