namespace Estigo.DTO
{
    public class DashboardDTO
    {
        public string StudentId { get; set; } 
        public string StudentName { get; set; } 
        public int StudentCode { get; set; }
        public List<EnrolledCourseDTO> EnrolledCourses { get; set; } = new List<EnrolledCourseDTO>();
        public List<InstructorImageDTO> CourseInstructors { get; set; } = new List<InstructorImageDTO>();
        public List<StudentExamHistoryDto> Quizzes { get; set; } = new List<StudentExamHistoryDto>();
        public List<PaymentInfoDTO> PaymentInfo { get; set; } = new List<PaymentInfoDTO>();
        public double AttendanceRate { get; set; }
    }
}
