namespace Estigo.DTO
{
    public class TeacherHomepageDTO
    {
        public string Name { get; set; }
        public string? Image { get; set; } // Now Image is a string (Base64)
        public string Subject { get; set; }
    }
}