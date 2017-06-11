namespace LetsJWT.Api.Core
{
    using System.Data.Entity;
    public class Initializer : MigrateDatabaseToLatestVersion<LetsJWTContext, Configuration>
    {
    }
}