namespace Saaly.Infrastructure.Mailers
{
    public interface IMailer
    {
        Task Send(MailBag mailBag);
    }
}