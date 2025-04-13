namespace Estigo.DTO
{
    public class SubmitQuizAnswerDTO
    {
        public string StudentId { get; set; }
        public int ExamId { get; set; }
        public List<AnswerDTO> Answers { get; set; }

        public class AnswerDTO
        {
            public int QuestionId { get; set; }
            public string SelectedOption { get; set; }
        }

    }
}
