using Estigo.DTO;
using Estigo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estigo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParentController : ControllerBase
    {
        private readonly EstigoDbContext _context;

        public ParentController(EstigoDbContext context)
        {
            _context = context;
        }

        //[HttpGet("student/{studentcode}")]
        //public async Task<ActionResult<object>> GetParentDashboard(int studentcode)
        //{
        //    var student = await _context.Students
        //        .Where(s => s.StudentCode == studentcode)
        //        .Select(s => new { s.Id, s.StudentCode, s.Name, s.Level, s.Track })
        //        .FirstOrDefaultAsync();

        //    if (student == null)
        //    {
        //        return NotFound($"Student with code {studentcode} not found.");
        //    }

        //    string studentIdForQueries = student.Id;

        //    var courses = await _context.MyCourses
        //        .Where(mc => mc.StudentId == studentIdForQueries)
        //        .Include(mc => mc.Course)
        //        .Select(mc => mc.Course)
        //        .Where(c => c != null)
        //        .OrderBy(c => c.CourseTitle)
        //        .Take(3)
        //        .Select(c => new
        //        {
        //            courseId = c.courseId,
        //            CourseTitle = c.CourseTitle,
        //            CourseLogo = c.Logo
        //        })
        //        .ToListAsync();

        //    var enrolledcourseIds = courses.Select(c => c.courseId).ToList();
        //    var availableExams = await _context.Exams
        //        .Where(e => e.Lesson != null && enrolledcourseIds.Contains(e.Lesson.courseId))
        //        .OrderByDescending(e => e.Id)
        //        .Take(2)
        //        .Select(e => new
        //        {
        //            ExamId = e.Id,
        //            ExamTitle = e.ExamTitle
        //        })
        //        .ToListAsync();

        //    var payments = await _context.Payments
        //        .Where(p => p.StudentId == studentIdForQueries)
        //        .OrderByDescending(p => p.PurchaseDate)
        //        .Take(2)
        //        .Select(p => new
        //        {
        //            PurchaseDate = p.PurchaseDate,
        //            CourseTitle = p.Course != null ? p.Course.CourseTitle : "N/A"
        //        })
        //        .ToListAsync();

        //    var dashboardData = new
        //    {
        //        StudentName = student.Name,
        //        StudentLevel = (int)student.Level,
        //        StudentTrack = student.Track,
        //        Courses = courses,
        //        Exams = availableExams,
        //        Payment = payments
        //    };

        //    return Ok(dashboardData);
        //}

        [HttpGet("student/{studentcode}/quizzes")]
        public async Task<ActionResult<object>> GetStudentQuizScores(int studentcode)
        {
            var student = await _context.Students
                .Where(s => s.StudentCode == studentcode)
                .Select(s => new { s.Id, s.Name })
                .FirstOrDefaultAsync();

            if (student == null)
            {
                return NotFound($"Student with code {studentcode} not found.");
            }

            var results = await _context.StudentExamResults
                .Where(r => r.StudentId == student.Id)
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

            var latestResults = results
                .GroupBy(r => r.ExamId)
                .Select(g => g.OrderByDescending(r => r.ExamDate).First())
                .ToList();

            return Ok(new
            {
                studentid = student.Id,
                StudentName = student.Name,
                ExamHistory = latestResults
            });
        }

    }
}