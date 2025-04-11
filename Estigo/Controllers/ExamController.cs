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
                .Include(e => e.Course)
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

        [HttpPost]
        public async Task<IActionResult> CreateExam([FromBody] ExamDTO exam)
        {
            if (exam == null || string.IsNullOrEmpty(exam.ExamTitle) || exam.Questions == null || exam.Questions.Count == 0)
            {
                return BadRequest("Please provide valid exam data.");
            }

            var newExam = new Exam
            {
                ExamTitle = exam.ExamTitle,
                ExamDescription = exam.ExamDescription,
                Grade = exam.Grade,
                courseId = exam.courseId,
                lessonId = exam.lessonId,
                Questions = exam.Questions.Select(q => new BankOfQuestion
                {
                    QuestionText = q.QuestionText,
                    OptionA = q.OptionA,
                    OptionB = q.OptionB,
                    OptionC = q.OptionC,
                    OptionD = q.OptionD,
                    CorrectAnswer = q.CorrectAnswer
                }).ToList()
            };

            context.Exams.Add(newExam);
            await context.SaveChangesAsync();

            var resultDto = new ExamDTO
            {
                Id = newExam.Id,
                ExamTitle = newExam.ExamTitle,
                ExamDescription = newExam.ExamDescription,
                Grade = newExam.Grade,
                courseId = newExam.courseId,
                lessonId = newExam.lessonId,
                Questions = newExam.Questions.Select(q => new QuestionDTO
                {
                    Id = q.Id,
                    QuestionText = q.QuestionText,
                    OptionA = q.OptionA,
                    OptionB = q.OptionB,
                    OptionC = q.OptionC,
                    OptionD = q.OptionD,
                    CorrectAnswer = q.CorrectAnswer
                }).ToList()
            };

            return Created($"api/Exam/{exam.Id}", exam);

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
            existingExam.courseId = exam.courseId;
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

        [HttpPost("SubmitAndCheckQuiz")]
        public async Task<ActionResult<object>> SubmitAndCheckQuiz([FromBody] SubmitQuizAnswerDTO dto)
        {
            var exam = await context.Exams
                .Include(e => e.Questions)
                .FirstOrDefaultAsync(e => e.Id == dto.ExamId);

            if (exam == null)
                return NotFound("Exam not found.");

            int totalQuestions = exam.Questions.Count;
            int correctAnswers = 0;

            foreach (var answer in dto.Answers)
            {
                var question = exam.Questions.FirstOrDefault(q => q.Id == answer.QuestionId);
                if (question != null && question.CorrectAnswer == answer.SelectedOption)
                {
                    correctAnswers++;
                }
            }

            double score = (double)correctAnswers / totalQuestions * 100;

            // Save the result
            var result = new StudentExamResult
            {
                StudentId = dto.StudentId,
                ExamId = dto.ExamId,
                Score = score,
                ExamDate = DateTime.Now
            };

            context.StudentExamResults.Add(result);
            await context.SaveChangesAsync();

            return Ok(new
            {
                Message = "Quiz submitted and graded successfully.",
                Score = score,
                CorrectAnswers = correctAnswers,
                TotalQuestions = totalQuestions
            });
        }

        // POST: api/StudentExamResults/SubmitResult
        [HttpPost("SubmitResult")]
        public async Task<ActionResult<StudentExamResult>> PostStudentExamResult([FromBody] SubmitExamResultDto dto)
        {
            // تأكد من وجود الطالب والامتحان
            var student = await context.Students.FindAsync(dto.StudentId);
            var exam = await context.Exams.FindAsync(dto.ExamId);

            if (student == null || exam == null)
            {
                return BadRequest("Student or Exam not found.");
            }

            // أنشئ النتيجة
            var result = new StudentExamResult
            {
                StudentId = dto.StudentId,
                ExamId = dto.ExamId,
                Score = dto.Score,
                ExamDate = DateTime.Now // أو لو عندك وقت مخصص ممكن تستلمه كمان من الـ DTO
            };

            context.StudentExamResults.Add(result);
            await context.SaveChangesAsync();

            return Ok("Grade stored successfully");
        }



    }
}
