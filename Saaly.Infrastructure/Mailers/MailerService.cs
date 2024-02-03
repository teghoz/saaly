using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saaly.Infrastructure.Mailers
{
    public class MailerService(IEnumerable<IMailer> mailerServices) : IMailerService
    {
        private readonly IEnumerable<IMailer> _mailerServices = mailerServices;

        public IMailer GetMailer(string? token)
        {
            return token switch
            {
                MailerConstants.Brevo => GetService(typeof(BrevoMailer)),
                MailerConstants.MailGun => GetService(typeof(MailgunMailer)),
                MailerConstants.MailChimp => GetService(typeof(MailChimpMailer)),
                MailerConstants.PostMark => GetService(typeof(PostmarkMailer)),
                MailerConstants.SendGrid => GetService(typeof(SendgridMailer)),
                MailerConstants.SMTP => GetService(typeof(SMTPMailer)),
                _ => GetService(typeof(BrevoMailer))
            };
        }

        private IMailer GetService(Type type)
        {
            return _mailerServices.FirstOrDefault(p => p.GetType() == type)!;
        }
    }
}
