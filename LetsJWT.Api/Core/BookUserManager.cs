using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace LetsJWT.Api.Core
{
    public class BookUserManager : UserManager<IdentityUser>
    {
        public BookUserManager() : base(new BookUserStore())
        {
        }

        public async Task<IdentityResult> ChangePassword(string userId, string newPassword)
        {
            this.RemovePassword(userId);
            return await AddPasswordAsync(userId, newPassword);
        }

        public static BookUserManager Create(IdentityFactoryOptions<BookUserManager> options, IOwinContext context)
        {
            var appUserManager = new BookUserManager();

            //// Configure validation logic for usernames
            //appUserManager.UserValidator = new UserValidator<IdentityUser>(appUserManager)
            //{
            //    AllowOnlyAlphanumericUserNames = true,
            //    RequireUniqueEmail = true
            //};

            //// Configure validation logic for passwords
            //appUserManager.PasswordValidator = new PasswordValidator
            //{
            //    RequiredLength = 6,
            //    RequireNonLetterOrDigit = true,
            //    RequireDigit = false,
            //    RequireLowercase = true,
            //    RequireUppercase = true,
            //};

            //appUserManager.EmailService = new AspNetIdentity.WebApi.Services.EmailService();

            //var dataProtectionProvider = options.DataProtectionProvider;
            //if (dataProtectionProvider != null)
            //{
            //    appUserManager.UserTokenProvider = new DataProtectorTokenProvider<IdentityUser>(dataProtectionProvider.Create("ASP.NET Identity"))
            //    {
            //        //Code for email confirmation and reset password life time
            //        TokenLifespan = TimeSpan.FromHours(6)
            //    };
            //}

            return appUserManager;
        }
    }
}