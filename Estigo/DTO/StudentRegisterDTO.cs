using System.ComponentModel.DataAnnotations;

namespace Estigo.DTO
{
    public class StudentRegisterDTO
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        [Phone]
        public string Phone { get; set; }
        public string Gender { get; set; }

        public DateOnly? BirthDate { get; set; }
        public string? Track { get; set; }
        public int? Level { get; set; }
        [Phone]
        public string? ParentPhone { get; set; }
    }
}
