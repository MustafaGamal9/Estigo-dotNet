using Estigo.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estigo.DTO
{
    public class ExamDTO
    {

        [Key]
        public int Id { get; set; }
        public string ExamTitle { get; set; }
        public string ExamDescription { get; set; }
        public string Grade { get; set; }

        [ForeignKey("Lesson")]
        public int lessonId { get; set; }
        public ICollection<QuestionDTO> Questions { get; set; }
    }
}
