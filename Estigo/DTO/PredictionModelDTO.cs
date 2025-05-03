namespace Estigo.DTO
{
    public class PredictionModelDTO
    {
        public float attendance_rate { get; set; } // attendance completion rate
        public float average_quiz_score { get; set; }
        public float quizzes_completion_rate { get; set; }
        public int final_exam_attempts { get; set; } 
        public float final_exam_score { get; set; } 
        public int education_system_IGCSE { get; set; }
    }
}
