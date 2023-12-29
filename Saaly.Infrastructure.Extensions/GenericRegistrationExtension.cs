using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Saaly.Infrastructure.Extensions
{
    public static class GenericRegistrationExtension
    {
        public static IServiceCollection AddGenericContext(this IServiceCollection services, Type type)
        {
            Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
            List<Type> concreteTypes = new List<Type>();
            foreach (Assembly assembly in assemblies)
            {
                Type[] typesInAssembly = assembly.GetTypes()
                    .Where(t => type.IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract)
                    .ToArray();

                concreteTypes.AddRange(typesInAssembly);
            }

            foreach (Type concreteType in concreteTypes)
            {
                Console.WriteLine($"Registered: {concreteType.FullName}");
                services.AddScoped(type, concreteType);
            }
            return services;
        }
    }
}
