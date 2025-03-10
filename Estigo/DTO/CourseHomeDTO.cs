using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Estigo.Models;

namespace Estigo.DTO
{
    public class CourseHomeDTO
    {
        public string CourseTitle { get; set; }
        public string? Logo { get; set; }

        public string? TeacherName { get; set; }
    }
}
