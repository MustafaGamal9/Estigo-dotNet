using Estigo.DTO;
using Estigo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        [HttpGet("Info/{name}")]
        public async Task<IActionResult> GetExamInfo(string name)
        {
            var exam = await context.Exams
                .Include(e => e.Lesson)
                .FirstOrDefaultAsync(e => e.ExamTitle == name);
            if (exam == null)
                return NotFound();
            var response = new
            {
                exam.Id,
                exam.ExamTitle,
                exam.ExamDescription,
              
            };
            return Ok(response);
        }  

        [HttpDelete]
        public async Task<IActionResult> DeleteExam(int id)
        {
            var exam = await context.Exams.FindAsync(id);
            if (exam == null)
                return NotFound();
            context.Exams.Remove(exam);
            await context.SaveChangesAsync();
            return Ok();
        }

       

        [HttpPut]
        public async Task<IActionResult> UpdateExam([FromBody] Exam exam)
        {
            if (exam == null || exam.Id == 0)
            {
                return BadRequest("Invalid exam data.");
            }

            var existingExam = await context.Exams.FindAsync(exam.Id);
            if (existingExam == null)
            {
                return NotFound();
            }

            existingExam.ExamTitle = exam.ExamTitle;
            existingExam.ExamDescription = exam.ExamDescription;
            existingExam.Grade = exam.Grade;
            existingExam.lessonId = exam.lessonId;

            context.Entry(existingExam).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet("GetQuestionsByExam/{examId}")]
        public IActionResult GetQuestionsByExam(int examId)
        {
            var questions = context.BankOfQuestions
                .Where(q => q.ExamId == examId)
                .Select(q => new 
                {
                    QuestionText = q.QuestionText,
                    OptionA = q.OptionA,
                    OptionB = q.OptionB,
                    OptionC = q.OptionC,
                    OptionD = q.OptionD,
                    CorrectAnswer = q.CorrectAnswer
                })
                .ToList();

            if (questions == null || !questions.Any())
            {
                return NotFound("No questions found for this exam.");
            }

            return Ok(questions);
        }

        [HttpGet("QuestionsWithoutAnswer/{examId}")]
        public IActionResult GetQuestionsWithoutAnswer(int examId)
        {
            var questions = context.BankOfQuestions
                .Where(q => q.ExamId == examId)
                .Select(q => new
                {
                    QuestionText = q.QuestionText,
                    OptionA = q.OptionA,
                    OptionB = q.OptionB,
                    OptionC = q.OptionC,
                    OptionD = q.OptionD,
                })
                .ToList();

            if (questions == null || !questions.Any())
            {
                return NotFound("No questions found for this exam.");
            }

            return Ok(questions);
        }


        [HttpGet("AnswerOnly/{examId}")]
        public IActionResult AnswerOnly(int examId)
        {
            var questions = context.BankOfQuestions
                .Where(q => q.ExamId == examId)
                .Select(q => new
                {
                    CorrectAnswer = q.CorrectAnswer
                })
                .ToList();

            if (questions == null || !questions.Any())
            {
                return NotFound("No questions found for this exam.");
            }

            return Ok(questions);
        }
        [HttpPost("SubmitQuizScore")]
        public async Task<ActionResult<object>> SubmitQuizScore([FromBody] SubmitQuizAnswerDTO dto)
        {
            var exam = await context.Exams.FindAsync(dto.ExamId);
            if (exam == null)
                return NotFound("Exam not found.");

            var student = await context.Students.FindAsync(dto.StudentId);
            if (student == null)
                return NotFound("Student not found.");

            var result = new StudentExamResult
            {
                StudentId = dto.StudentId,
                ExamId = dto.ExamId,
                Score = dto.Score,
            };

            context.StudentExamResults.Add(result);
            await context.SaveChangesAsync();

            return Ok(new
            {
                Message = "Quiz score submitted successfully.",
                Score = dto.Score
            });
        }

        //// POST: api/StudentExamResults/SubmitResult
        //[HttpPost("SubmitResult")]
        //public async Task<ActionResult<StudentExamResult>> PostStudentExamResult([FromBody] SubmitExamResultDto dto)
        //{
        //    // تأكد من وجود الطالب والامتحان
        //    var student = await context.Students.FindAsync(dto.StudentId);
        //    var exam = await context.Exams.FindAsync(dto.ExamId);

        //    if (student == null || exam == null)
        //    {
        //        return BadRequest("Student or Exam not found.");
        //    }

        //    // أنشئ النتيجة
        //    var result = new StudentExamResult
        //    {
        //        StudentId = dto.StudentId,
        //        ExamId = dto.ExamId,
        //        Score = dto.Score,
        //        ExamDate = DateTime.Now // أو لو عندك وقت مخصص ممكن تستلمه كمان من الـ DTO
        //    };

        //    context.StudentExamResults.Add(result);
        //    await context.SaveChangesAsync();

        //    return Ok("Grade stored successfully");
        //}
        [HttpGet("GetExamsByStudentId/{studentId}")]
        public async Task<ActionResult<IEnumerable<StudentExamHistoryDto>>> GetExamsByStudentId(string studentId)
        {
            var studentExists = await context.Students.AnyAsync(s => s.Id == studentId);
            if (!studentExists)
            {
                return NotFound($"Student with ID {studentId} not found.");
            }

            var results = await context.StudentExamResults
                .Where(r => r.StudentId == studentId)
                .Include(r => r.Exam)
                    .ThenInclude(e => e.Lesson)
                .Select(r => new StudentExamHistoryDto
                {
                    ExamId = r.ExamId,
                    ExamTitle = r.Exam.ExamTitle,
                    Score = r.Score,
                    ExamDate = r.ExamDate,
                    LessonName = r.Exam.Lesson != null ? r.Exam.Lesson.lessonTitle : "N/A"
                })
                .ToListAsync();

            // Remove duplicates if any (e.g., duplicate ExamId)
            var distinctResults = results
                .GroupBy(r => new { r.ExamId }) // or use ExamId only, depending on your logic
                .Select(g => g.First())
                .OrderByDescending(dto => dto.ExamDate)
                .ToList();

            return Ok(distinctResults);
        }

        [HttpGet("GetStudentAverageByCategory/{studentId}/{categoryId}")]
        public async Task<ActionResult<double>> GetStudentAverageByCategory(string studentId, int categoryId)
        {
            var studentExists = await context.Students.AnyAsync(s => s.Id == studentId);
            if (!studentExists)
            {
                return NotFound($"Student with ID {studentId} not found.");
            }

            var examScores = await context.StudentExamResults
                .Where(r => r.StudentId == studentId)
                .Where(r => r.Exam.Lesson.Course.CategoryId == categoryId)
                .GroupBy(r => r.ExamId) // Group by ExamId to ensure distinct exams  
                .Select(g => g.First().Score) // Take the first score for each distinct exam  
                .ToListAsync();

            if (!examScores.Any())
            {
                return NotFound($"No exams found for student {studentId} in category {categoryId}.");
            }

            // Calculate the average  
            double averageScore = examScores.Average();

            return Ok("Exams Avg score: " + averageScore);
        }



    }
}
