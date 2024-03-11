using Saaly.Infrastucture.Configurations;
using SendWithBrevo;

namespace Saaly.Infrastructure.Mailers
{
    public class BrevoMailer : IMailer
    {
        private BrevoClient _client;
        public async Task Send(MailBag mailBag)
        {
            _client = new BrevoClient(SaalyConfig.Instance.Messaging.BrevoAPIKey);
            await _client.SendAsync(
                new Sender(mailBag.Sender, mailBag.Email),
                new List<Recipient> { new Recipient("[their name]", "[their email]") },
                mailBag.Subject,
                mailBag.HtmlBody,
                isHtml: true);
        }
    }
}
