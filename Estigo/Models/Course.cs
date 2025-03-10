using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estigo.Models
{
    public class Course
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

        // Foreign key
        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        [ForeignKey("Teacher")] 
        public string? TeacherId { get; set; }

        // Navigation property
        public Category Category { get; set; }
        public ICollection<Student> students { get; set; }
        public ICollection<Chapter> Chapters { get; set; }

        public ICollection<Payment> Payments { get; set; }


        public Teacher? Teacher { get; set; }



    }
}
