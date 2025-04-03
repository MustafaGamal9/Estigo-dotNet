using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Estigo.DTO
{
    public class LessonDTO
    {
        [Key]
        public int lessonId { get; set; }
        public string lessonTitle { get; set; }
        public string lessonDescription { get; set; }
        public string lessonContent { get; set; }
        public string lessonVideo { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdatedAt { get; set; }


        // Navigation Properties
        public int courseId { get; set; }
    }
}
