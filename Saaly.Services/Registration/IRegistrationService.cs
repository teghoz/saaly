using Saaly.Services.Requests;

namespace Saaly.Services.Registration
{
    public interface IRegistrationService
    {
        Task Register(RegistrationBaseRequest request);
    }
}