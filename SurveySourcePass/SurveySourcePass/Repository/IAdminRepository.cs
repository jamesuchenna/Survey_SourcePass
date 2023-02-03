using SurveySourcePass.Models;

namespace SurveySourcePass.Repository
{
    public interface IAdminRepository
    {
        public Task<string> Add(Survey survey);
    }
}
