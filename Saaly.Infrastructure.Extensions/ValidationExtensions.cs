using Microsoft.Extensions.DependencyInjection;

namespace Saaly.Infrastructure.Extensions
{
    public static class ValidationExtensions
    {
        public static IServiceCollection AddValidations(this IServiceCollection services, Type type)
        {

            return services;
        }
    }
}
