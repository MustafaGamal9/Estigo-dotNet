using System.ComponentModel.DataAnnotations;

namespace Estigo.DTO
{
    public class RegisterDTO
    {
        public string Name { get; set; }
        public string Password { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string Phone { get; set; }
        public string Gender { get; set; }
        public DateOnly BirthDate { get; set; }
        public string Track { get; set; }
        public int Level { get; set; }
        [Phone]
        public string ParentPhone { get; set; }
    }
}
