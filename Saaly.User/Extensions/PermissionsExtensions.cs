using Saaly.Infrastructure.Extensions.Requirements;
using Saaly.User.Claims;

namespace Saaly.User.Extensions
{
    public static class PermissionsExtensions
    {
        public static IServiceCollection AddPermissions(this IServiceCollection services)
        {
            services.AddAuthorization(options =>
            {
                #region Dashboard
                options.AddPolicy(SaalyClaimConstants.DashboardView, policy =>
                    policy.Requirements.Add(new IsViewableRequirement(SaalyClaimConstants.DashboardView)));
                #endregion

                #region Profile
                options.AddPolicy(SaalyClaimConstants.AdminProfileView, policy =>
                    policy.Requirements.Add(new IsViewableInDetailsRequirement(SaalyClaimConstants.AdminProfileView)));

                options.AddPolicy(SaalyClaimConstants.AdminProfileEdit, policy =>
                    policy.Requirements.Add(new IsViewableInDetailsRequirement(SaalyClaimConstants.AdminProfileEdit)));

                options.AddPolicy(SaalyClaimConstants.ProfileView, policy =>
                    policy.Requirements.Add(new IsViewableInDetailsRequirement(SaalyClaimConstants.ProfileView)));

                options.AddPolicy(SaalyClaimConstants.ProfileEdit, policy =>
                    policy.Requirements.Add(new IsEditableRequirement(SaalyClaimConstants.ProfileEdit)));

                options.AddPolicy(SaalyClaimConstants.SettingsView, policy =>
                    policy.Requirements.Add(new IsEditableRequirement(SaalyClaimConstants.SettingsView)));
                #endregion

                #region Users
                options.AddPolicy(SaalyClaimConstants.UsersCreate, policy =>
                    policy.Requirements.Add(new IsCreateableRequirement(SaalyClaimConstants.UsersCreate)));

                options.AddPolicy(SaalyClaimConstants.UsersEdit, policy =>
                    policy.Requirements.Add(new IsEditableRequirement(SaalyClaimConstants.UsersEdit)));

                options.AddPolicy(SaalyClaimConstants.UsersList, policy =>
                    policy.Requirements.Add(new IsViewableRequirement(SaalyClaimConstants.UsersList)));

                options.AddPolicy(SaalyClaimConstants.UsersView, policy =>
                    policy.Requirements.Add(new IsViewableInDetailsRequirement(SaalyClaimConstants.UsersView)));

                options.AddPolicy(SaalyClaimConstants.UsersDelete, policy =>
                    policy.Requirements.Add(new IsDeleteableRequirement(SaalyClaimConstants.UsersDelete)));
                #endregion
            });

            return services;
        }
    }
}
