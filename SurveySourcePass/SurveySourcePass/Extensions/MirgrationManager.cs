using SurveySourcePass.DAL;

namespace SurveySourcePass.Extensions
{
    public static class MigrationManager
    {
        /*public static IHost MigrateDatabase(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var databaseService = scope.ServiceProvider.GetRequiredService<Database>();

                try
                {
                    databaseService.CreateDatabase("SurveySourcePass");
                }
                catch
                {
                    //log errors or ...
                    throw;
                }
            }

            return host;
        }*/
    }
}
