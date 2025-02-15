using Estigo.DTO;
using Estigo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
                    catogryid = c.CategoryId
                }).ToList();

            return Ok(courses);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetCourseById(int id)
        {
            var course = context.Courses.Select(c=> new courseDTO
            {
                CourseId = c.CourseId,
                CourseTitle = c.CourseTitle,
                Description = c.Description,
                Logo = c.Logo,
                Price = c.Price,
                Available = c.Available,
                CreatedAt = c.CreatedAt,
                UpdatedAt = c.UpdatedAt,
                catogryid = c.CategoryId
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
                catogryid = c.CategoryId
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
                CategoryId = courseDto.catogryid
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
    }
}
