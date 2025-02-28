using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estigo.Models
{
    public class StudentExamResult
    {
        [Key]
        public int Id { get; set; }
        public double Score { get; set; }
        public DateTime ExamDate { get; set; }

        // Navigation Properties
        [ForeignKey("Student")]
        public string StudentId { get; set; }
        public Student Student { get; set; }

        [ForeignKey("Exam")]
        public int ExamId { get; set; }
        public Exam Exam { get; set; }
    }
}
