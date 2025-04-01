using Estigo.DTO;
using Estigo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

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


        // Meet our instructors section
        [HttpGet("HomepageTeachers")]
        public async Task<IActionResult> GetHomepageTeachers()
        {
            var teachers = await _context.Teachers
                .Select(teacher => new TeacherHomepageDTO
                {
                    Name = teacher.Name,
                    Image = teacher.image != null ? Convert.ToBase64String(teacher.image) : null,
                    Subject = teacher.Subject
                })
                .Take(4)
                .ToListAsync();

            if (teachers == null || teachers.Count == 0)
            {
                return Ok(new List<TeacherHomepageDTO>());
            }

            return Ok(teachers);
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


        [HttpPut("{id}/image")]
        public async Task<IActionResult> UpdateTeacherImage(string id, IFormFile image)
        {
            try
            {
                Console.WriteLine($"Received request to update image for teacher {id}");
                Console.WriteLine($"File name: {image?.FileName}");
                Console.WriteLine($"File size: {image?.Length} bytes");

                if (image == null || image.Length == 0)
                {
                    Console.WriteLine("No file was uploaded");
                    return BadRequest(new { message = "No file uploaded" });
                }

                // Validate file type
                var allowedExtensions = new[] { ".jpg", ".jpeg", ".png", ".gif" };
                var fileExtension = Path.GetExtension(image.FileName).ToLowerInvariant();
                Console.WriteLine($"File extension: {fileExtension}");
                
                if (!allowedExtensions.Contains(fileExtension))
                {
                    Console.WriteLine($"Invalid file type: {fileExtension}");
                    return BadRequest(new { message = "Invalid file type. Only JPG, JPEG, PNG and GIF files are allowed." });
                }

                // Validate file size (max 5MB)
                if (image.Length > 5 * 1024 * 1024)
                {
                    Console.WriteLine($"File too large: {image.Length} bytes");
                    return BadRequest(new { message = "File size too large. Maximum size is 5MB." });
                }

                var teacher = await _context.Teachers.FindAsync(id);
                if (teacher == null)
                {
                    Console.WriteLine($"Teacher not found: {id}");
                    return NotFound(new { message = "Teacher not found" });
                }

                Console.WriteLine("Processing file upload...");
                using (var memoryStream = new MemoryStream())
                {
                    await image.CopyToAsync(memoryStream);
                    teacher.image = memoryStream.ToArray();
                    Console.WriteLine($"File processed successfully. Size: {teacher.image.Length} bytes");
                }

                await _context.SaveChangesAsync();
                Console.WriteLine("Changes saved to database");
                return Ok(new { message = "Teacher image updated successfully" });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred: {ex.Message}");
                Console.WriteLine($"Stack trace: {ex.StackTrace}");
                return StatusCode(500, new { message = "An error occurred while updating the teacher image", error = ex.Message });
            }
        }
    }
}