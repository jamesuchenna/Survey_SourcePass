namespace SurveySourcePass.Models
{
    public class SurveyQuestion
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public int SurveyId { get; set; }
        public Survey Survey { get; set; }

        public int AnswerId { get; set; }
        public List<SurveyAnswer> Answers { get; set; }
    }
}
