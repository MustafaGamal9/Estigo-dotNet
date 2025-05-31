using System.ComponentModel.DataAnnotations;

namespace Estigo.Models
{
    public class QuestionAnswer
    {
        [Key]
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public string SelectedOption { get; set; }
        public bool IsCorrect { get; set; }

        // Foreign key to StudentExamResult
        public int StudentExamResultId { get; set; }
        public StudentExamResult StudentExamResult { get; set; }
    }
}
