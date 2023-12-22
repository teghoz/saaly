using Saaly.Infrastucture.Configurations;

namespace Saaly.Infrastructure.Configurations
{
    public class GeneralConfig : IConfig
    {
        public string? AdminUserPrefix => ConfigHelper.Instance.GetValueFromAppSettings("General:AdminUserPrefix", defaultValue: "SA");
        public int DefaultPageCount => ConfigHelper.Instance.GetValueFromAppSettings("General:DefaultPageCount", defaultValue: 20);

        public void Validate()
        {
        }
    }
}
