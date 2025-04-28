using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static Estigo.Enums.CourseStatus;

namespace Estigo.DTO
{
    public class courseDTO
    {
        [Key]
        public int courseId { get; set; }
        public string CourseTitle { get; set; }
        public string? Description { get; set; }
        public string? Logo { get; set; }
        public int Price { get; set; }
        public bool Available { get; set; } = true;

        public int attendance { get; set; }
        public CourseStatusEnum Status { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdatedAt { get; set; }
        public int catogryid { get; set; }
        public string? TeacherId { get; set; }
    }
}
