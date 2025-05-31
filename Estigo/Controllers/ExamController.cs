using Estigo.DTO;
using Estigo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Text;

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

        [HttpGet("Info/{id}")]
        public async Task<IActionResult> GetExamInfo(int id)
        {
            var exam = await context.Exams
                .Include(e => e.Lesson)
                .FirstOrDefaultAsync(e => e.Id == id);
            if (exam == null)
                return NotFound();
            var response = new
            {
                exam.Id,
                exam.ExamTitle,
                exam.ExamDescription,
                exam.final
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
        public async Task<ActionResult<object>> SubmitQuizScore([FromBody] SubmitExamResultDto dto)
        {
            // Find the exam by ID
            var exam = await context.Exams.FindAsync(dto.ExamId);
            if (exam == null)
                return NotFound("Exam not found.");

            // Find the student by ID
            var student = await context.Students.FindAsync(dto.StudentId);
            if (student == null)
                return NotFound("Student not found.");

            // Create a new StudentExamResult object and map QuestionAnswers inside it
            var result = new StudentExamResult
            {
                StudentId = dto.StudentId,
                ExamId = dto.ExamId,
                Score = dto.Score,
                ExamDate = DateTime.Now,
                Answers = dto.QuestionAnswers.Select(qa => new QuestionAnswer
                {
                    QuestionId = qa.QuestionId,
                    SelectedOption = qa.SelectedOption,
                    IsCorrect = qa.IsCorrect
                }).ToList()
            };

            // Add the exam result (with answers) to the database
            context.StudentExamResults.Add(result);

            // If the exam is final, increment the attempts count
            if (exam.final)
            {
                exam.attempts++;
                context.Entry(exam).State = EntityState.Modified;
            }

            // Save all changes in one transaction
            await context.SaveChangesAsync();

            // Return success response with details
            return Ok(new
            {
                Message = "Quiz score and answers submitted successfully.",
                Score = dto.Score,
                IsFinalExam = exam.final,
                Attempts = exam.final ? exam.attempts : 0
            });
        }





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
    }
}

