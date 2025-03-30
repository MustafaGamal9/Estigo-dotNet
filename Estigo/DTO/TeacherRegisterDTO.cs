using System.ComponentModel.DataAnnotations;

namespace Estigo.DTO
{
    public class TeacherRegisterDTO
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

        public string Subject { get; set; }
        public string? Notes { get; set; }

        public IFormFile image { get; set; }
    }
}
