using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using SurveySourcePass.Models;
using System.Collections.Generic;
using System.Data;

namespace SurveySourcePass.DAL
{
    public interface IAppDbContext
    {
        public IDbConnection Connection { get; }
        DatabaseFacade Database { get; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Survey> Surveys { get; set; }
        public DbSet<SurveyAnswer> SurveyAnswers { get; set; }
        public DbSet<SurveyQuestion> SurveyQuestions { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
