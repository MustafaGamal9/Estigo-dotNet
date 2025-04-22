using System;

namespace Estigo.DTO
{
    public class StudentExamHistoryDto
    {
        public int ExamId { get; set; }
        public string ExamTitle { get; set; }
        public double Score { get; set; }
        public DateTime ExamDate { get; set; }
        public string LessonName { get; set; }
    }
}