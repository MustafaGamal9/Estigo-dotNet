using System.ComponentModel.DataAnnotations;

namespace Estigo.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }


        // Navigation property
        public ICollection<Course> Courses { get; set; }


    }
}
