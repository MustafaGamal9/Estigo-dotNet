using Estigo.DTO;
using Estigo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Estigo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        EstigoDbContext context;

        public CourseController(EstigoDbContext _context)
        {
            context = _context;
        }
        [HttpGet]
        public IActionResult GetCourses()
        {
            List<courseDTO> courses = context.Courses
                .Select(c => new courseDTO
                {
                    CourseId = c.CourseId,
                    CourseTitle = c.CourseTitle,
                    Description = c.Description,
                    Logo = c.Logo,
                    Price = c.Price,
                    Available = c.Available,
                    CreatedAt = c.CreatedAt,
                    UpdatedAt = c.UpdatedAt,
                    catogryid = c.CategoryId,
                    TeacherId = c.TeacherId
                }).ToList();

            return Ok(courses);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetCourseById(int id)
        {
            var course = context.Courses.Select(c => new courseDTO
            {
                CourseId = c.CourseId,
                CourseTitle = c.CourseTitle,
                Description = c.Description,
                Logo = c.Logo,
                Price = c.Price,
                Available = c.Available,
                CreatedAt = c.CreatedAt,
                UpdatedAt = c.UpdatedAt,
                catogryid = c.CategoryId,
                TeacherId = c.TeacherId
            }).FirstOrDefault(c => c.CourseId == id);

            if (course == null)
            {
                return NotFound(new { message = "Course not found" });
            }

            return Ok(course);

        }

        [HttpGet("{id:int}/details")]
        public IActionResult GetCourseDetailsById(int id)
        {
            var course = context.Courses.Select(c => new CourseDetailsDTO
            {
                CourseId = c.CourseId,
                CourseTitle = c.CourseTitle,
                Description = c.Description,
                Logo = c.Logo,
                Price = c.Price,
                TeacherName = c.Teacher != null ? c.Teacher.Name : null,
                lessons = c.lessons.Select(l => l.lessonTitle).ToList()


            }).FirstOrDefault(c => c.CourseId == id);

            if (course == null)
            {
                return NotFound(new { message = "Course not found" });
            }

            return Ok(course);

        }

        [HttpGet("{name}")]
        public IActionResult GetCourseByName(string name)
        {
            var course = context.Courses.Select(c => new courseDTO
            {
                CourseId = c.CourseId,
                CourseTitle = c.CourseTitle,
                Description = c.Description,
                Logo = c.Logo,
                Price = c.Price,
                Available = c.Available,
                CreatedAt = c.CreatedAt,
                UpdatedAt = c.UpdatedAt,
                catogryid = c.CategoryId,
                TeacherId = c.TeacherId
            }).FirstOrDefault(c => c.CourseTitle == name);

            if (course == null)
            {
                return NotFound(new { message = "Course not found" });
            }

            return Ok(course);
        }


        [HttpPost]
        public IActionResult AddCourse(courseDTO courseDto)
        {
            var course = new Course
            {
                CourseId = courseDto.CourseId,
                CourseTitle = courseDto.CourseTitle,
                Description = courseDto.Description,
                Logo = courseDto.Logo,
                Price = courseDto.Price,
                Available = courseDto.Available,
                CategoryId = courseDto.catogryid,
                TeacherId = courseDto.TeacherId
            };

            context.Courses.Add(course);
            context.SaveChanges();

            return Ok();
        }

        [HttpPut("{id:int}")]
        public IActionResult EditCourse(int id, courseDTO courseDto)
        {
            var course = context.Courses.FirstOrDefault(c => c.CourseId == id);
            if (course == null)
            {
                return NotFound(new { message = "Course not found" });
            }
            course.CourseTitle = courseDto.CourseTitle;
            course.Description = courseDto.Description;
            course.Logo = courseDto.Logo;
            course.Price = courseDto.Price;
            course.Available = courseDto.Available;
            context.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteCourse(int id)
        {
            var course = context.Courses.FirstOrDefault(c => c.CourseId == id);
            if (course == null)
            {
                return NotFound(new { message = "Course not found" });
            }
            context.Courses.Remove(course);
            context.SaveChanges();
            return Ok();
        }
        // Our popular courses section
        [HttpGet("HomepageCourses")]
        public async Task<IActionResult> GetPopularCourses()
        {
            var courses = await context.Courses
                .Include(c => c.Teacher)
                .Where(c => c.Available)
                .Take(4)
                .ToListAsync();

            if (courses == null || courses.Count == 0)
            {
                return Ok(new List<CourseHomeDTO>()); // Return empty list if no courses found
            }

            var popularCoursesDTOs = courses.Select(course => new CourseHomeDTO
            {
                CourseId = course.CourseId,
                CourseTitle = course.CourseTitle,
                ImageBase64 = course.Logo != null ? Convert.ToBase64String(course.Logo) : null,
                TeacherName = course.Teacher?.Name
            }).ToList();

            return Ok(popularCoursesDTOs);
        }

        [HttpPut("{id:int}/logo")]
        public async Task<IActionResult> UpdateCourseLogo(int id, IFormFile logo)
        {
            try
            {
                Console.WriteLine($"Received request to update logo for course {id}");
                Console.WriteLine($"File name: {logo?.FileName}");
                Console.WriteLine($"File size: {logo?.Length} bytes");

                if (logo == null || logo.Length == 0)
                {
                    Console.WriteLine("No file was uploaded");
                    return BadRequest(new { message = "No file uploaded" });
                }

                // Validate file type
                var allowedExtensions = new[] { ".jpg", ".jpeg", ".png", ".gif" };
                var fileExtension = Path.GetExtension(logo.FileName).ToLowerInvariant();
                Console.WriteLine($"File extension: {fileExtension}");

                if (!allowedExtensions.Contains(fileExtension))
                {
                    Console.WriteLine($"Invalid file type: {fileExtension}");
                    return BadRequest(new { message = "Invalid file type. Only JPG, JPEG, PNG and GIF files are allowed." });
                }

                // Validate file size (max 5MB)
                if (logo.Length > 5 * 1024 * 1024)
                {
                    Console.WriteLine($"File too large: {logo.Length} bytes");
                    return BadRequest(new { message = "File size too large. Maximum size is 5MB." });
                }

                var course = await context.Courses.FindAsync(id);
                if (course == null)
                {
                    Console.WriteLine($"Course not found: {id}");
                    return NotFound(new { message = "Course not found" });
                }

                Console.WriteLine("Processing file upload...");
                using (var memoryStream = new MemoryStream())
                {
                    await logo.CopyToAsync(memoryStream);
                    course.Logo = memoryStream.ToArray();
                    Console.WriteLine($"File processed successfully. Size: {course.Logo.Length} bytes");
                }

                await context.SaveChangesAsync();
                Console.WriteLine("Changes saved to database");
                return Ok(new { message = "Course logo updated successfully" });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred: {ex.Message}");
                Console.WriteLine($"Stack trace: {ex.StackTrace}");
                return StatusCode(500, new { message = "An error occurred while updating the course logo", error = ex.Message });
            }
        }

    [HttpGet("category/{categoryId}")]
    public async Task<ActionResult<IEnumerable<Course>>> GetCoursesByCategoryVm(int categoryId)
    {
        try
        {
            var courses = await context.Courses
                .Include(c => c.Teacher)
                .Where(c => c.CategoryId == categoryId)
                .ToListAsync();
            var courseVms = courses.Select(c => new CoursePageDTO
            {
                CourseId = c.CourseId,
                CourseTitle = c.CourseTitle,
                ImageBase64 = c.Logo != null ? Convert.ToBase64String(c.Logo) : null,
                price = c.Price,
                TeacherName = c.Teacher != null ? c.Teacher.Name : null
            }).ToList();

            if (courses == null || !courses.Any())
            {
                return NotFound(new { message = "No courses found for this category" });
            }

            return Ok(courseVms);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error occurred: {ex.Message}");
            Console.WriteLine($"Stack trace: {ex.StackTrace}");
            return StatusCode(500, new { message = "An error occurred while retrieving courses", error = ex.Message });
        }
    }

    [HttpGet("category/limited/{categoryId}")]
    public async Task<ActionResult<IEnumerable<CoursePageDTO>>> GetCoursesByCategory(int categoryId)
    {
        try
        {
            var courses = await context.Courses
                .Include(c => c.Teacher)
                .Where(c => c.CategoryId == categoryId)
                .Take(4)
                .ToListAsync();

            if (courses == null || !courses.Any())
            {
                return NotFound(new { message = "No courses found for this category" });
            }

            var courseVms = courses.Select(c => new CoursePageDTO
            {
                CourseId = c.CourseId,
                CourseTitle = c.CourseTitle,
                ImageBase64 = c.Logo != null ? Convert.ToBase64String(c.Logo) : null,
                price = c.Price,
                TeacherName = c.Teacher != null ? c.Teacher.Name : null
            }).ToList();

            return Ok(courseVms);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error occurred: {ex.Message}");
            Console.WriteLine($"Stack trace: {ex.StackTrace}");
            return StatusCode(500, new { message = "An error occurred while retrieving courses", error = ex.Message });
        }
    }


    }

}
