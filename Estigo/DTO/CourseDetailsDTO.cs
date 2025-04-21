using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static Estigo.Enums.CourseStatus;

namespace Estigo.DTO
{
    public class CourseDetailsDTO
    {
        [Key]
        public int CourseId { get; set; }
        public string CourseTitle { get; set; }
        public string? Description { get; set; }
        public string? Logo { get; set; }
        public int Price { get; set; }
        public string? TeacherName { get; set; }

        public List<string> lessons { get; set; } = new List<string>();
        public CourseStatusEnum Status { get; set; }
    }
}
