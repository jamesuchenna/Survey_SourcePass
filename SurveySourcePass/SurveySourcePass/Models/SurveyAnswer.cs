namespace SurveySourcePass.Models
{
    public class SurveyAnswer
    {
        public int Id { get; set; }
        public string Response { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public int SurveyQuestionId { get; set; }
        public SurveyQuestion SurveyQuestion { get; set; }
    }
}
