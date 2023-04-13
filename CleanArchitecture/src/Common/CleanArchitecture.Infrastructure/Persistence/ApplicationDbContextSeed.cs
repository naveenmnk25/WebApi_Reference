using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Infrastructure.Entity;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Persistence
{
    public static class ApplicationDbContextSeed
    {
        public static async Task SeedDefaultUserAsync(UserManager<ApplicationUser> userManager, RoleManager<Role> roleManager)
        {
            var administratorRole = new Role();
            administratorRole.Name = "Administrator";

            if (roleManager.Roles.All(r => r.Name != administratorRole.Name))
            {
                await roleManager.CreateAsync(administratorRole);
            }

            var defaultUser = new ApplicationUser { UserName = "iayti", Email = "test@test.com" };
            if (userManager.Users.All(u => u.UserName != defaultUser.UserName))
            {
                await userManager.CreateAsync(defaultUser, "Matech_1850");
                await userManager.AddToRolesAsync(defaultUser, new[] { administratorRole.Name });
            }
        }

        public static async Task SeedCompanyUserAsync(UserManager<ApplicationUser> userManager, RoleManager<Role> roleManager)
        {
            List<ApplicationUser> users = new List<ApplicationUser>();
            //users.Add(new ApplicationUser { UserName = "JP-005607", Email = "dotnetindia@euroland.com", CompanyCode = "JP-005607" });

            //var administratorRole = new Role();
            //administratorRole.Name = "Administrator";

            //if (roleManager.Roles.All(r => r.Name != administratorRole.Name))
            //{
            //    await roleManager.CreateAsync(administratorRole);
            //}

            foreach (var user in users)
            {
                if (userManager.Users.All(u => u.UserName != user.UserName))
                {
                    await userManager.CreateAsync(user, "Euroland@123");
                    await userManager.AddToRolesAsync(user, new[] { "Administrator" });
                }
            }
        }

        public static async Task SeedSampleCityDataAsync(ApplicationDbContext context)
        {
          
        }
    }
}
