using Microsoft.AspNetCore.Authorization;
using Saaly.Infrastructure.Extensions.Requirements;

namespace Saaly.Infrastructure.Extensions.Handlers
{
    public class PageCreatableAuthorizationHandler : AuthorizationHandler<IsCreateableRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, IsCreateableRequirement requirement)
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
