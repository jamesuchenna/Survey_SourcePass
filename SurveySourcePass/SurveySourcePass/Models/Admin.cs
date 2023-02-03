namespace SurveySourcePass.Models
{
    public class Admin
    {
        public int Id { get; set; }
        public string AdminName { get; set; }
        public int SurveyId { get; set; }
        public List<Survey> Surveys { get; set; }
    }
}
