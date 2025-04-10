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
    public async Task<ActionResult<DashboardDTO>> GetStudentDashboard(string studentId) // Receive string studentId
    {
        // --- Fetch Student Details ---
        var student = await _context.Students
            .Where(s => s.Id == studentId) 
            .Select(s => new { s.Id, s.Name }) 
            .FirstOrDefaultAsync();

        if (student == null)
        {
            return NotFound($"Student with ID {studentId} not found.");
        }

        // Fetch Enrolled Courses
        var enrolledCourses = await _context.MyCourses
            .Where(mc => mc.StudentId == studentId)
            .Include(mc => mc.Course)
            .Select(mc => mc.Course)
            .Where(c => c != null) 
            .OrderBy(c => c.CourseTitle) 
            .Take(3)
            .Select(c => new EnrolledCourseDTO
            {
                CourseName = c.CourseTitle,
                CourseImageUrl = c.Logo
            })
            .ToListAsync();


        var courseInstructors = await _context.MyCourses
            .Where(mc => mc.StudentId == studentId)
            .Include(mc => mc.Course)
                .ThenInclude(c => c.Teacher)
            .Select(mc => mc.Course.Teacher)
            .Distinct() 
            .Take(3) 
            .Select(t => new InstructorImageDTO
            {
                InstructorImageUrl = t.image
            })
            .ToListAsync();

        // --- Fetch Quizzes (Latest 2 for Enrolled Courses - Original Logic Kept) ---
        var enrolledCourseIds = await _context.MyCourses
                                    .Where(mc => mc.StudentId == studentId)
                                    .Select(mc => mc.CourseId)
                                    .Distinct()
                                    .ToListAsync();

        var quizzes = await _context.Exams
            .Where(q => enrolledCourseIds.Contains(q.Id)) 
            .Take(2)
            .Select(q => new QuizInfoDTO
            {
                QuizId = q.Id,
                QuizName = q.ExamTitle
            })
            .ToListAsync();


        //Fetch Payment Info
        var paymentInfo = await _context.Payments
            .Where(p => p.StudentId == studentId)
            .Take(2) // Take latest 2
            .Select(p => new PaymentInfoDTO 
            {
               
                PaymentDescription = p.PaymentMethod
               
            })
            .ToListAsync();

        // --- Assemble the DTO ---
        var dashboardData = new DashboardDTO 
        {
            StudentId = student.Id,
            StudentName = student.Name,
            EnrolledCourses = enrolledCourses,
            CourseInstructors = courseInstructors,
            PaymentInfo = paymentInfo
        };

        return Ok(dashboardData);
    }
}