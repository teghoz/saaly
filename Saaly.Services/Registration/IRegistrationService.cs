using Microsoft.AspNetCore.Identity;
using Saaly.Services.Requests;

namespace Saaly.Services.Registration
{
    public interface IRegistrationService
    {
        Task<IdentityResult?> Register(RegistrationBaseRequest request);
    }
}