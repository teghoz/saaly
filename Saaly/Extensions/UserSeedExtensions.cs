using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Saaly.Data;
using Saaly.Data.Extensions;
using Saaly.Infrastucture.Configurations;
using Saaly.Models;

namespace Saaly.Extensions
{
    public static class UserSeedExtensions
    {
        public static async Task<IApplicationBuilder> SeedUser(this IApplicationBuilder app)
        {
            using var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>()?.CreateScope();
            var context = serviceScope?.ServiceProvider.GetRequiredService<SaalyContext>();
            //context.Database.SetCommandTimeout(3000);
            context?.Database.Migrate();
            var userManager = serviceScope?.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            var roleManager = serviceScope?.ServiceProvider.GetRequiredService<RoleManager<IdentityRole<Guid>>>();

            var seedRoles = async (RoleManager<IdentityRole<Guid>> roleManager) =>
            {
                var roles = new[] { "Admin", "User" };

                foreach (var r in roles)
                {
                    var isExist = await roleManager.RoleExistsAsync(r);

                    if (!isExist)
                    {
                        var role = new IdentityRole<Guid>(r);
                        await roleManager.CreateAsync(role);
                    }
                }
            };
            var seedDefaultUser = async (SaalyContext context) =>
            {
                var hasDefaultUser = await context.Admins.AnyAsync(a => a.Username == "0123456789");
                if (!hasDefaultUser)
                {
                    var user = new ApplicationUser();

                    user.Admin = new Admin();
                    user.Admin.Contact = new Contact();
                    user.Admin.Contact.FirstName = "Aghogho";
                    user.Admin.Contact.LastName = "Bernard";
                    var prefix = SaalyConfig.Instance.General.AdminUserPrefix;
                    user.Admin.Contact.Code = await "".GenerateCode(context.Admins, prefix, user.Admin.Contact.FullName, true);
                    user.Admin.Contact.Email = "admin@outside.co";
                    user.Admin.Contact.PhoneNumber = "+234 012 345 6789";
                    user.Admin.Contact.IsActive = true;
                    user.Admin.Username = "0123456789";
                    user.Admin.IsActive = true;
                    user.Admin.DefaultUser = true;

                    user.FirstName = "Aghogho";
                    user.LastName = "Bernard";
                    user.Email = "admin@saalyapp.com";
                    user.UserName = "0123456789";
                    user.PhoneNumber = "0123456789";
                    user.EmailConfirmed = true;
                    user.PhoneNumberConfirmed = true;

                    if (userManager is not null)
                    {
                        var result = await userManager.CreateAsync(user, "Sa@ly_2024");
                        if (result.Succeeded)
                        {
                            user.AdminGuid = user.Admin.Guid;
                            await userManager.AddToRoleAsync(user, "Admin");
                            await context.SaveChangesAsync();
                        }
                    }
                }
            };
            await seedRoles(roleManager);
            await seedDefaultUser(context);

            return app;
        }
    }
}
