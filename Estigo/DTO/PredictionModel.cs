namespace Estigo.DTO
{
    public class PredictionModel
    {
        public float assignment_completion_rate { get; set; } // attendance completion rate
        public float average_quiz_score { get; set; }
        public float material_completion_rate { get; set; }

        public float time_spent_per_week { get; set; } // videos watched per week
        public int final_exam_attempts { get; set; } 
        public float final_exam_score { get; set; } 
        public int education_system_IGCSE { get; set; } // male or female
    }
}
