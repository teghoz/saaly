using MassTransit;
using Microsoft.Extensions.DependencyInjection;
using Saaly.Infrastucture.Configurations;

namespace Saaly.Infrastructure.Extensions
{
    public static class AsynchronousMessagingExtensions
    {
        public static IServiceCollection AddAsyncMessaging(this IServiceCollection services, Action<IBusRegistrationConfigurator>? consumerRegistrations, Action<IRabbitMqBusFactoryConfigurator, IBusRegistrationContext>? receiveEndpointConfigurations)
        {
            services.AddMassTransit(x =>
            {
                consumerRegistrations?.Invoke(x);
                // A Transport
                x.UsingRabbitMq((context, cfg) =>
                {
                    cfg.Host(SaalyConfig.Instance.Messaging.RabbitConnection, (ushort)SaalyConfig.Instance.Messaging.RabbitPort, SaalyConfig.Instance.Messaging.RabbitVirtualHost, h =>
                    {
                        h.Username(SaalyConfig.Instance.Messaging.RabbitUsername);
                        h.Password(SaalyConfig.Instance.Messaging.RabbitPassword);
                    });

                    receiveEndpointConfigurations?.Invoke(cfg, context);

                    cfg.ConfigureEndpoints(context);
                });
            });

            services.AddTransient<IMessagingService, MessagingService>();
            return services;
        }
    }
}
