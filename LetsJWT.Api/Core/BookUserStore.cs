namespace LetsJWT.Api.Core
{
    using Microsoft.AspNet.Identity.EntityFramework;

    public class BookUserStore : UserStore<IdentityUser>
    {
        public BookUserStore() : base(new LetsJWTContext())
        {
        }
    }
}