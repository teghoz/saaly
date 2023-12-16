using Saaly.Infrastructure.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saaly.Infrastucture.Configurations
{
    public class SaalyConfig
    {
        private static readonly Lazy<SaalyConfig> Lazy = new();
        public static SaalyConfig Instance => Lazy.Value;

        public SaalyConfig()
        {
            Database = new DatabaseConfig();
            Password = new PasswordConfig();
            General = new GeneralConfig();
        }

        public string? Environment => ConfigHelper.Instance.GetValueFromAppSettings("Environment", optional: false, defaultValue: "Staging");
        public string? ProjectName => ConfigHelper.Instance.GetValueFromAppSettings("ProjectName", optional: false, defaultValue: "Saaly");
        public string? IpServer => ConfigHelper.Instance.GetValueFromAppSettings("IpServer", optional: true, defaultValue: "https://showify-restriction-server.herokuapp.com/json/");

        public DatabaseConfig Database { get; set; }
        public PasswordConfig Password { get; set; }
        public GeneralConfig General { get; set; }

        public void Validate(){}
}
}
