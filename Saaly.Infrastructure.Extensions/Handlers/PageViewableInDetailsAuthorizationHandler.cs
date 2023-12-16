using Microsoft.AspNetCore.Authorization;
using Saaly.Infrastructure.Extensions.Requirements;

namespace YoodaloShared.Authorization
{
    public class PageViewableInDetailsAuthorizationHandler : AuthorizationHandler<IsViewableInDetailsRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, IsViewableInDetailsRequirement requirement)
        {
            if (context.User.HasClaim(
                    c => c.Type == requirement.Claim && c.Value == requirement.Claim))
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}
