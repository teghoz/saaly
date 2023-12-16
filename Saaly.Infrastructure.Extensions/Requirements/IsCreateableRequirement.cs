using Microsoft.AspNetCore.Authorization;

namespace Saaly.Infrastructure.Extensions.Requirements
{
    public class IsCreateableRequirement : IAuthorizationRequirement
    {
        public string Claim { get; set; }
        public IsCreateableRequirement(string claim)
        {
            Claim = claim;
        }
    }
}
