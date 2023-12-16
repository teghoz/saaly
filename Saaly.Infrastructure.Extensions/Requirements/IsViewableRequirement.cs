using Microsoft.AspNetCore.Authorization;

namespace Saaly.Infrastructure.Extensions.Requirements
{
    public class IsViewableRequirement : IAuthorizationRequirement
    {
        public string Claim { get; set; }
        public IsViewableRequirement(string claim)
        {
            Claim = claim;
        }
    }
}
