using Dapper;
using SurveySourcePass.DAL;
using SurveySourcePass.Models;
using System.Data;

namespace SurveySourcePass.Repository
{
    public class AdminRepository : IAdminRepository
    {
        private readonly DapperDbConnection _dapperDbConnection;
        public string procedureName = "spSurvey";

        public AdminRepository(DapperDbConnection dapperDbConnection)
        {
            _dapperDbConnection = dapperDbConnection;
        }
        public async Task<string> Add(Survey survey)
        {
            try
            {
                using (var con = _dapperDbConnection.CreateConnection())
                {
                    var addSurvey = await con.ExecuteAsync
                        (procedureName, commandType: CommandType.StoredProcedure);

                    return "Successful";
                }

            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
