namespace Estigo.DTO
{
    public class DashboardDTO
    {
        public string StudentId { get; set; } 
        public string StudentName { get; set; } 
        public List<EnrolledCourseDTO> EnrolledCourses { get; set; } = new List<EnrolledCourseDTO>();
        public List<InstructorImageDTO> CourseInstructors { get; set; } = new List<InstructorImageDTO>();
        public List<QuizInfoDTO> Quizzes { get; set; } = new List<QuizInfoDTO>();
        public List<PaymentInfoDTO> PaymentInfo { get; set; } = new List<PaymentInfoDTO>();
    }
}
