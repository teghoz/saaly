
namespace Saaly.Services.Recaptcha
{
    public interface ICaptchaService
    {
        Task<bool> Verify(string encodedResponse);
    }
}