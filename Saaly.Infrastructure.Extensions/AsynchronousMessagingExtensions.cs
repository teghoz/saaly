using MassTransit;
using Microsoft.Extensions.DependencyInjection;

namespace Saaly.Infrastructure.Extensions
{
    public static class AsynchronousMessagingExtensions
    {
        public static IServiceCollection AddAsycnMessaging(this IServiceCollection services)
        {
            services.AddMassTransit(x =>
            {
                // A Transport
                x.UsingRabbitMq((context, cfg) =>
                {

                });
            });
            return services;
        }
    }
}
