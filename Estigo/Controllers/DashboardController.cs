using Estigo.DTO;
using Estigo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

[ApiController]
[Route("api/[controller]")]
public class DashboardController : ControllerBase
{
    private readonly EstigoDbContext _context;

    public DashboardController(EstigoDbContext context)
    {
        _context = context;
    }

    [HttpGet("student/{studentId}")]
    public async Task<ActionResult<DashboardDTO>> GetStudentDashboard(string studentId)
    {
        // --- Fetch Student Details ---
        var student = await _context.Students
            .Where(s => s.Id == studentId)
            .Select(s => new { s.Id, s.Name,s.StudentCode })
            .FirstOrDefaultAsync();

        if (student == null)
        {
            return NotFound($"Student with ID {studentId} not found.");
        }

        // --- Fetch Enrolled Courses ---
        var enrolledCourses = await _context.MyCourses
            .Where(mc => mc.StudentId == studentId)
            .Include(mc => mc.Course) 
            .Select(mc => mc.Course)
            .Where(c => c != null) 
            .OrderBy(c => c.CourseTitle)
            .Take(3)
            .Select(c => new EnrolledCourseDTO
            {
                courseId = c.courseId,
                CourseName = c.CourseTitle,
                CourseImageUrl = c.Logo 
            })
            .ToListAsync();


        // --- Fetch Instructors for Enrolled Courses ---
        var courseInstructors = await _context.MyCourses
           .Where(mc => mc.StudentId == studentId && mc.Course != null && mc.Course.Teacher != null)
           .Select(mc => mc.Course.Teacher) 
           .Distinct()
           .Take(3)
           .Select(t => new InstructorImageDTO 
           {
               InstructorImageUrl = t.image
           })
           .ToListAsync();


        // --- Fetch Latest 2 Exam Results (Score, Lesson Name, etc.) ---
        var latestExamResults = await _context.StudentExamResults
            .Where(r => r.StudentId == studentId)
            .Include(r => r.Exam)
                .ThenInclude(e => e.Lesson)
            .OrderByDescending(r => r.ExamDate)
            .Take(2)
            .Select(r => new StudentExamHistoryDto
            {
                ExamId = r.ExamId,
                ExamTitle = r.Exam != null ? r.Exam.ExamTitle : "N/A",
                Score = r.Score,
                ExamDate = r.ExamDate,
                LessonName = (r.Exam != null && r.Exam.Lesson != null) ? r.Exam.Lesson.lessonTitle : "N/A"
            })
            .ToListAsync();


        // --- Fetch Payment Info (Latest 2) ---
        var paymentInfo = await _context.Payments
            .Where(p => p.StudentId == studentId)
            .Include(p => p.Course) 
            .OrderByDescending(p => p.PurchaseDate)
            .Take(2)
            .Select(p => new PaymentInfoDTO
            {
                PurchaseDate = p.PurchaseDate,
                CourseTitle = p.Course != null ? p.Course.CourseTitle : "N/A"
            })
            .ToListAsync();

        // --- Assemble the DTO ---
        var dashboardData = new DashboardDTO
        {
            StudentId = student.Id,
            StudentName = student.Name,
            StudentCode = student.StudentCode,
            EnrolledCourses = enrolledCourses,
            CourseInstructors = courseInstructors,
            Quizzes = latestExamResults,
            PaymentInfo = paymentInfo
        };

        return Ok(dashboardData);
    }

}