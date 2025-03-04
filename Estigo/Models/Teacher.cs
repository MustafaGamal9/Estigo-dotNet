using Microsoft.AspNetCore.Identity;

namespace Estigo.Models
{
    public class Teacher:ApplicationUser
    {
        public string Subject { get; set; }
        public string? Notes { get; set; }

        public byte[]? image { get; set; }
    }
}
