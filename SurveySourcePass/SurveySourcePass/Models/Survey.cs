namespace SurveySourcePass.Models
{
    public class Survey
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public int QuestionId { get; set; }
        public List<SurveyQuestion> Questions { get; set; }
    }
}
