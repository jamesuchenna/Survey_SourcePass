using Microsoft.Data.SqlClient;
using System.Data;

namespace SurveySourcePass.DAL
{
    public class DapperDbConnection
    {
        private readonly IConfiguration _configuration;
        private readonly string _connection;

        public DapperDbConnection(IConfiguration configuration)
        {
            _configuration = configuration;
            _connection = _configuration.GetConnectionString("Survey");
        }

        public IDbConnection CreateConnection() => new SqlConnection(_connection);
    }
}
