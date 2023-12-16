using Microsoft.AspNetCore.Authorization;

namespace Saaly.Infrastructure.Extensions.Requirements
{
    public class IsViewableInDetailsRequirement : IAuthorizationRequirement
    {
        public string Claim { get; set; }
        public IsViewableInDetailsRequirement(string claim)
        {
            Claim = claim;
        }
    }
}
