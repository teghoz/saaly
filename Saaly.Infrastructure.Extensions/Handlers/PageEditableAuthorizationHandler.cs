using Microsoft.AspNetCore.Authorization;
using Saaly.Infrastructure.Extensions.Requirements;
using System.Threading.Tasks;

namespace Saaly.Infrastructure.Extensions.Handlers
{
    public class PageEditableAuthorizationHandler : AuthorizationHandler<IsEditableRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, IsEditableRequirement requirement)
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
