
namespace LetsJWT.Api.Core
{
    using System.Data.Entity.Migrations;

    public class Configuration : DbMigrationsConfiguration<LetsJWTContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = false;
        }
    }
}