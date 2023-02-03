using Dapper;
using SurveySourcePass.DAL;
using SurveySourcePass.Models;
using System.Data;

namespace SurveySourcePass.Repository
{
    public class SurveyRepository : ISurveyRepository
    {
        private readonly DapperDbConnection _dapperDbConnection;
        public string procedureName = "spSurvey";

        public SurveyRepository(DapperDbConnection dapperDbConnection)
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

        public async Task<Survey> Get(int id)
        {
            var parameter = new DynamicParameters();
            parameter.Add("Id", id, DbType.Int32, ParameterDirection.Input);

            using (var con = _dapperDbConnection.CreateConnection())
            {
                var survey = await con.QueryFirstOrDefaultAsync<Survey>
                    (procedureName, parameter, commandType: CommandType.StoredProcedure);

                return survey;
            }
        }

        public async Task<List<Survey>> GetAll()
        {
            using (var con = _dapperDbConnection.CreateConnection())
            {
                var survey = await con.QueryAsync<Survey>
                    (procedureName, commandType: CommandType.StoredProcedure);

                return survey.ToList();
            }
        }
    }
}
