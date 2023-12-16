using Microsoft.AspNetCore.Authorization;

namespace Saaly.Infrastructure.Extensions.Requirements
{
    public class IsDeleteableRequirement : IAuthorizationRequirement
    {
        public string Claim { get; set; }
        public IsDeleteableRequirement(string claim)
        {
            Claim = claim;
        }
    }
}
