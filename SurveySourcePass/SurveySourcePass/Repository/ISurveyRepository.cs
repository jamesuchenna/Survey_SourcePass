using SurveySourcePass.Models;

namespace SurveySourcePass.Repository
{
    public interface ISurveyRepository
    {
        public Task<string> Add(Survey survey);
        public Task<Survey> Get(int id);
        public Task<List<Survey>> GetAll();
    }
}
