namespace Saaly.Infrastructure.Mailers
{
    public interface IMailerService
    {
        IMailer GetMailer(string? token);
    }
}