using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Estigo.Models;

namespace Estigo.DTO
{
    public class CourseHomeDTO
    {
        [Key]
        public int courseId { get; set; }
        public string CourseTitle { get; set; }
        public string? ImageBase64 { get; set; }
        public string? TeacherName { get; set; }
    }
}
