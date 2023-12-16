using Microsoft.AspNetCore.Authorization;

namespace Saaly.Infrastructure.Extensions.Requirements
{
    public class IsEditableRequirement : IAuthorizationRequirement
    {
        public string Claim { get; set; }
        public IsEditableRequirement(string claim)
        {
            Claim = claim;
        }
    }
}
