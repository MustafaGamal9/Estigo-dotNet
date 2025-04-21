namespace Estigo.DTO
{
    public class ParentDashboardDTO
    {
        public string StudentName { get; set; }
        public int StudentLevel { get; set; }
        public string StudentTrack { get; set; }
        public List<ExamDTO> Exams { get; set; } = new(); // Simplified initialization to address IDE0028
        public List<courseDTO> Courses { get; set; } = new(); // Simplified initialization to address IDE0028
        public List<PaymentDTO> Payment { get; set; } = new(); // Simplified initialization to address IDE0028
    }
}
