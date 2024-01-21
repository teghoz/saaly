using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
