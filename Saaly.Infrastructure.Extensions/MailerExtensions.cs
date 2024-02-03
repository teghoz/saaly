using Microsoft.Extensions.DependencyInjection;
using Saaly.Infrastructure.Mailers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saaly.Infrastructure.Extensions
{
    public static class MailerExtensions
    {
        public static IServiceCollection RegisterMailers(this IServiceCollection services)
        {
            services.AddSingleton<IMailer, BrevoMailer>();
            services.AddSingleton<IMailer, SMTPMailer>();
            services.AddSingleton<IMailer, MailChimpMailer>();
            services.AddSingleton<IMailer, MailgunMailer>();
            services.AddSingleton<IMailer, SMTPMailer>();
            services.AddSingleton<IMailer, PostmarkMailer>();

            services.AddSingleton<IMailerService, MailerService>();
            return services;
        }
    }
}
