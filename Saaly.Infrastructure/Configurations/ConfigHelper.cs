using Microsoft.Extensions.Configuration;
using System.Configuration;
using System.Globalization;

namespace Saaly.Infrastucture.Configurations
{
    public class ConfigHelper
    {
        private static readonly Lazy<ConfigHelper> _instance = new();

        public static ConfigHelper Instance => _instance.Value;

        public string? GetValueFromAppSettings(string key, bool optional = false)
        {
            return GetValueFromAppSettings<string>(key, null, optional);
        }

        public static IConfiguration GetConfiguration()
        {
            var builder = new ConfigurationBuilder()
                            .SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                            .AddJsonFile("connection.json", optional: false, reloadOnChange: true)
                            .AddEnvironmentVariables();

            IConfiguration configuration = builder.Build();

            return configuration;
        }

        public T? GetValueFromAppSettings<T>(string key, T? defaultValue = default, bool optional = false)
        {
            var value = GetConfiguration().GetValue(key, defaultValue)?.ToString();

            if (string.IsNullOrEmpty(value))
            {
                if (!optional && defaultValue.Equals(default(T)))
                {
                    throw new ConfigurationException($@"Key or value is mising in AppSettings for {key} and no default value is provided.");
                }
            }

            return ConvertValue(value, defaultValue);
        }

        private static T? ConvertValue<T>(string? value, T defaultValue)
        {
            var type = typeof(T);

            if (string.IsNullOrEmpty(value))
            {
                return defaultValue;
            }

            return (T)Convert.ChangeType(value, type, CultureInfo.InvariantCulture);
        }
    }
}
