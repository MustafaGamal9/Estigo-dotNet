using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Estigo.DTO
{
    public class courseDTO
    {
        [Key]
        public int CourseId { get; set; }
        public string CourseTitle { get; set; }
        public string? Description { get; set; }
        public string? Logo { get; set; }
        public int Price { get; set; }
        public bool Available { get; set; } = true;

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdatedAt { get; set; }
        public int catogryid { get; set; }
        public string? TeacherId { get; set; }
    }
}
