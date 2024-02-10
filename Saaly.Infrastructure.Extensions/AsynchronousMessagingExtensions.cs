using MassTransit;
using Microsoft.Extensions.DependencyInjection;
using Saaly.Infrastucture.Configurations;

namespace Saaly.Infrastructure.Extensions
{
    public static class AsynchronousMessagingExtensions
    {
        public static IServiceCollection AddAsyncMessaging(this IServiceCollection services, Action<IBusRegistrationConfigurator> extraRegistrations)
        {

            services.AddMassTransit(x =>
            {
                extraRegistrations?.Invoke(x);
                // A Transport
                x.UsingRabbitMq((context, cfg) =>
                {
                    cfg.Host(SaalyConfig.Instance.Messaging.RabbitConnection, (ushort)SaalyConfig.Instance.Messaging.RabbitPort, SaalyConfig.Instance.Messaging.RabbitVirtualHost, h =>
                    {
                        h.Username(SaalyConfig.Instance.Messaging.RabbitUsername);
                        h.Password(SaalyConfig.Instance.Messaging.RabbitPassword);
                    });

                    cfg.ConfigureEndpoints(context);
                });
            });

            services.AddTransient<IMessagingService, MessagingService>();
            return services;
        }
    }
}
