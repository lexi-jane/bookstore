//MISSION 11
using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Bookstore.Models
{
    // static class --> not creating instances of the class, but want to make changes to the class itself
    public static class IdentitySeedData
    {

        private const string adminUser = "Admin";
        private const string adminPassword = "413ExtraYeetPeriod(t)!";

        //public static int num = 0;

        public static async void EnsurePopulated(IApplicationBuilder app)
        {
            AppIdentityDBContext context = app.ApplicationServices
                .CreateScope().ServiceProvider
                .GetRequiredService<AppIdentityDBContext>();

            //if there are any migrations that need to be run, then run them
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            UserManager<IdentityUser> userManager = app.ApplicationServices
                .CreateScope().ServiceProvider
                .GetRequiredService<UserManager<IdentityUser>>();

            //get a user with the name adminUser
            IdentityUser user = await userManager.FindByIdAsync(adminUser);

            //if adminUser doesn't exist, then set up a new user with the name adminUser
            if (user == null)
            {
                user = new IdentityUser(adminUser);

                user.Email = "admin@test.com";
                user.PhoneNumber = "111-1234";

                await userManager.CreateAsync(user, adminPassword);
                //await userManager.CreateAsync(adminUser, adminPassword);
            }
        }
    }
}
