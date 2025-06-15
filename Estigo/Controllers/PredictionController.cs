using Estigo.DTO;
using Estigo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace Estigo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PredictionController : ControllerBase
    {

        EstigoDbContext context;
        private readonly HttpClient _httpClient;

        public PredictionController(EstigoDbContext _context, IHttpClientFactory httpClientFactory)
        {
            context = _context;
            _httpClient = httpClientFactory.CreateClient();
        }

        [HttpGet("model-values/{studentId}/{categoryId}")]
        public async Task<ActionResult<object>> GetStudentAverageByCategory(string studentId, int categoryId)
        {
            var student = await context.Students.FirstOrDefaultAsync(s => s.Id == studentId);
            if (student == null)
            {
                return NotFound($"Student with ID {studentId} not found.");
            }

            // Attendance
            var enrolledCourses = await context.MyCourses
                .Where(mc => mc.StudentId == studentId)
                .Where(mc => mc.Course.CategoryId == categoryId)
                .ToListAsync();

            var totalCoursesInCategory = await context.Courses
                .Where(c => c.CategoryId == categoryId)
                .CountAsync();

            double attendanceRate = 0;
            if (totalCoursesInCategory > 0)
            {
                int totalAttendance = enrolledCourses.Sum(c => c.attendance);

                // Calculate attendance as percentage of ALL courses in category accessed
                attendanceRate = (totalAttendance / (double)totalCoursesInCategory) * 100;
            }

            // Regular exams = quizzes
            var quizResults = await context.StudentExamResults
                .Where(r => r.StudentId == studentId)
                .Where(r => r.Exam.Lesson.Course.CategoryId == categoryId)
                .Where(r => r.Exam.final == false)
                .GroupBy(r => r.ExamId)
                .Select(g => g.First())
                .ToListAsync();

            int quizzesTaken = quizResults.Count;

            // Total quizzes defined in this category
            var totalQuizzes = await context.Exams
                .Where(e => e.Lesson.Course.CategoryId == categoryId)
                .Where(e => e.final == false)
                .CountAsync();

            double quizCompletionRate = (totalQuizzes > 0)
                ? Math.Min(100, (quizzesTaken / (double)totalQuizzes) * 100)
                : 0;

            // Final exam (just one)
            var finalExam = await context.StudentExamResults
                .Where(r => r.StudentId == studentId)
                .Where(r => r.Exam.Lesson.Course.CategoryId == categoryId)
                .Where(r => r.Exam.final == true)
                .Select(r => new
                {
                    Score = r.Score,
                    Attempts = r.Exam.attempts
                })
                .FirstOrDefaultAsync();

            return Ok(new
            {
                attendance_rate = attendanceRate,
                average_quiz_score = quizResults.Any() ? quizResults.Average(r => r.Score) : 0,
                quizzes_completion_rate = quizCompletionRate,
                final_exam_attempts = finalExam?.Attempts ?? 0,
                final_exam_score = finalExam?.Score ?? 0,
                education_system_IGCSE = student.Track.ToLower() == "ig" ? 1 : 0,
            });
        }

        [HttpGet("model-result/{studentId}/{categoryId}")]
        public async Task<ActionResult<object>> ModelTest(string studentId, int categoryId)
        {
            var student = await context.Students.FirstOrDefaultAsync(s => s.Id == studentId);
            if (student == null)
            {
                return NotFound($"Student with ID {studentId} not found.");
            }

            // Attendance
            var enrolledCourses = await context.MyCourses
                .Where(mc => mc.StudentId == studentId)
                .Where(mc => mc.Course.CategoryId == categoryId)
                .ToListAsync();

            var totalCoursesInCategory = await context.Courses
                .Where(c => c.CategoryId == categoryId)
                .CountAsync();

            double attendanceRate = 0;
            if (totalCoursesInCategory > 0)
            {
                int totalAttendance = enrolledCourses.Sum(c => c.attendance);

                // Calculate attendance as percentage of ALL courses in category accessed
                attendanceRate = (totalAttendance / (double)totalCoursesInCategory) * 100;
            }

            // Regular exams - student
            var regularExamScores = await context.StudentExamResults
                .Where(r => r.StudentId == studentId)
                .Where(r => r.Exam.Lesson.Course.CategoryId == categoryId)
                .Where(r => r.Exam.final == false)
                .GroupBy(r => r.ExamId)
                .Select(g => g.First().Score)
                .ToListAsync();

            // Regular exams - all students (for completion rate calculation)
            var totalQuizzes = await context.Exams
                .Where(e => e.Lesson.Course.CategoryId == categoryId)
                .Where(e => e.final == false)
                .CountAsync();

            int quizzesTaken = regularExamScores.Count;
            double quizCompletionRate = (totalQuizzes > 0)
                ? Math.Min(100, (quizzesTaken / (double)totalQuizzes) * 100)
                : 0;

            // Final exam 
            var finalExam = await context.StudentExamResults
                .Where(r => r.StudentId == studentId)
                .Where(r => r.Exam.Lesson.Course.CategoryId == categoryId)
                .Where(r => r.Exam.final == true)
                .Select(r => new
                {
                    Score = r.Score,
                    Attempts = r.Exam.attempts
                })
                .FirstOrDefaultAsync();

            double regularExamsAverage = regularExamScores.Any() ? regularExamScores.Average() : 0;

            // Prepare the data for the Fast API
            var fastApiRequest = new
            {
                attendance_rate = attendanceRate,
                average_quiz_score = regularExamsAverage,
                quizzes_completion_rate = quizCompletionRate,
                final_exam_attempts = finalExam?.Attempts ?? 0,
                final_exam_score = finalExam?.Score ?? 0,
                education_system_IGCSE = student.Track.ToLower() == "ig" ? 1 : 0
            };

            // Serialize the request to JSON
            var jsonRequest = JsonConvert.SerializeObject(fastApiRequest);
            var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

            // Send the request to the Fast API
            using (var httpClient = new HttpClient())
            {
                try
                {
                    // await Task.Delay(5000); // Uncomment only for testing startup delay
                    var response = await httpClient.PostAsync("https://mustafag17-student-grade-predictor.hf.space/predict-grade", content);
                    response.EnsureSuccessStatusCode();

                    // Read the response from the Fast API
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    var fastApiResponse = JsonConvert.DeserializeObject<dynamic>(jsonResponse);

                    return Ok(fastApiResponse);
                }
                catch (HttpRequestException ex)
                {
                    // Handle potential errors from the Fast API call
                    return StatusCode(500, $"Error calling Fast API: {ex.Message}");
                }
            }
        }




        [HttpPost("model-test")]
        public async Task<IActionResult> GetPredictedGrade([FromBody] PredictionModelDTO input)
        {
            var fastApiUrl = "https://mustafag17-student-grade-predictor.hf.space/predict-grade";

            var response = await _httpClient.PostAsJsonAsync(fastApiUrl, input);

            if (!response.IsSuccessStatusCode)
            {
                return StatusCode((int)response.StatusCode, "FastAPI service failed.");
            }

            var result = await response.Content.ReadFromJsonAsync<Dictionary<string, string>>();
            return Ok(result);
        }
    }
}
