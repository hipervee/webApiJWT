namespace LetsJWT.Api.Core
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System.Data.Entity;

    public class LetsJWTContext : IdentityDbContext
    {
        public LetsJWTContext()
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}