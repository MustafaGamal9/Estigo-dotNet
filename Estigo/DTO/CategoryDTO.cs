using System.ComponentModel.DataAnnotations;

namespace Estigo.DTO
{
    public class CategoryDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Category Name is required")]
        public string Name { get; set; }
    }
}