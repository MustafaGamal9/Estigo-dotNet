using Estigo.Models;
using System.ComponentModel.DataAnnotations;
using static Estigo.Enums.CourseStatus;

namespace Estigo.DTO
{
    public class CoursePageDTO
    {
        public int CourseId { get; set; }
        public string CourseTitle { get; set; }
        public string? ImageBase64 { get; set; }

        public string CatName { get; set; }
        public int price { get; set; }

        public string? TeacherName { get; set; }
        public CourseStatusEnum Status { get; set; }
    }
}
