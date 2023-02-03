using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using SurveySourcePass.Models;
using System.Data;
using System.Data.SqlClient;

namespace SurveySourcePass.DAL
{
    public class AppDbContext : DbContext, IAppDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DatabaseFacade Database => throw new NotImplementedException();

        public DbSet<SurveyAnswer> SurveyAnswers { get; set; }
        public DbSet<SurveyQuestion> SurveyQuestions { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Survey> Surveys { get; set; }
        public IDbConnection Connection => Database.GetDbConnection();

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
