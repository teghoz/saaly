using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Saaly.Data;
using Saaly.Infrastucture.Configurations;
using Saaly.Models;

namespace Saaly.Infrastructure.Extensions
{
    public static class IdentityExtensions
    {
        public static IServiceCollection AddSaalyContext(this IServiceCollection services, Action<CustomIdentityOption> customIdentityOptions)
        {
            var identityOptions = new CustomIdentityOption();
            customIdentityOptions?.Invoke(identityOptions);

            services.AddDataProtection().PersistKeysToDbContext<SaalyContext>().SetApplicationName(SaalyConfig.Instance.ProjectName);

            services.AddDbContext<SaalyContext>(options => options.UseNpgsql(identityOptions.ConnectionString).EnableSensitiveDataLogging())
                    .AddDefaultIdentity<ApplicationUser>(options =>
                    {
                        // Password settings.
                        options.Password.RequireDigit = SaalyConfig.Instance.Password.RequireDigit;
                        options.Password.RequireLowercase = SaalyConfig.Instance.Password.RequireLowerCase;
                        options.Password.RequireNonAlphanumeric = SaalyConfig.Instance.Password.RequireNonAlphaNumeric;
                        options.Password.RequireUppercase = SaalyConfig.Instance.Password.RequireUpperCase;
                        options.Password.RequiredLength = SaalyConfig.Instance.Password.MinimumPasswordLength;
                        options.Password.RequiredUniqueChars = SaalyConfig.Instance.Password.RequireUniqueCharacters;

                        // Lockout settings.
                        options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(SaalyConfig.Instance.Password.DefaultLockedTimespan);
                        options.Lockout.MaxFailedAccessAttempts = SaalyConfig.Instance.Password.MaximumFailedAttempts;
                        options.Lockout.AllowedForNewUsers = true;

                        // User settings.
                        options.User.AllowedUserNameCharacters = SaalyConfig.Instance.Password.AllowedCharacters;
                        options.User.RequireUniqueEmail = false;
                    })
                    .AddRoles<IdentityRole<Guid>>()
                    .AddEntityFrameworkStores<SaalyContext>()
                    .AddDefaultTokenProviders();

            services.AddAssemblyTriggers();

            return services;
        }
        public static IServiceCollection AddCookieIdentity(this IServiceCollection services, Action<CustomIdentityOption> customIdentityOptions, Action<IServiceCollection> extraRegistrations)
        {
            var identityOptions = new CustomIdentityOption();
            customIdentityOptions?.Invoke(identityOptions);

            extraRegistrations.Invoke(services);
            services.ConfigureApplicationCookie(identityOptions.AuthenticationOptions);

            services.AddSession();

            return services;
        }
    }
}
