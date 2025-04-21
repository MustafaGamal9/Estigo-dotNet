using Estigo.DTO;
using Estigo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Estigo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParentController : ControllerBase
    {
        EstigoDbContext _context;
        public ParentController(EstigoDbContext context)
        {
            _context = context;
        }

        [HttpGet("student/{studentcode}")]
        public async Task<ActionResult<ParentDashboardDTO>> GetParentDashboard(int studentcode)
        {
            // --- Fetch Student Details ---
            var student = await _context.Students
                .Where(s => s.StudentCode == studentcode)
                .Select(s => new { s.StudentCode, s.Name, s.Level, s.Track })
                .FirstOrDefaultAsync();

            if (student == null)
            {
                return NotFound($"Student with code {studentcode} not found.");
            }

            string studentIdStr = student.StudentCode.ToString();

            // --- Fetch Enrolled Courses ---
            var courses = await _context.MyCourses
                .Where(mc => mc.StudentId == studentIdStr)
                .Include(mc => mc.Course)
                .Select(mc => mc.Course)
                .Where(c => c != null)
                .OrderBy(c => c.CourseTitle)
                .Take(3)
                .Select(c => new 
                {
                    CourseId = c.CourseId,
                    CourseTitle = c.CourseTitle,
                    CourseLogo = c.Logo
                })
                .ToListAsync();

            // --- Fetch Exams (Quizzes) for Enrolled Courses ---
            var enrolledCourseIds = courses.Select(c => c.CourseId).ToList();

            var exams = await _context.Exams
                .Where(e => enrolledCourseIds.Contains(e.lessonId))
                .OrderByDescending(e => e.Id)
                .Take(2)
                .Select(e => new 
                {
                    ExamId = e.Id,
                    ExamTitle = e.ExamTitle
                })
                .ToListAsync();

            // --- Fetch Payment Info ---
            var payments = await _context.Payments
                .Where(p => p.StudentId == studentIdStr)
                .OrderByDescending(p => p.PurchaseDate)
                .Take(2)
                .Select(p => new 
                {
                    PurchaseDate = p.PurchaseDate,
                    CourseTitle = p.Course.CourseTitle
                })
                .ToListAsync();

            // --- Assemble the DTO ---
            var dashboardData = new 
            {
                StudentName = student.Name,
                StudentLevel = (int)student.Level,
                StudentTrack = student.Track,
                Courses = courses,
                Exams = exams,
                Payment = payments
            };

            return Ok(dashboardData);
        }
    }
}
