using Saaly.Infrastucture.Configurations;

namespace Saaly.Infrastructure.Configurations
{
    public class GeneralConfig : IConfig
    {
        public int DefaultPageCount => ConfigHelper.Instance.GetValueFromAppSettings("General:DefaultPageCount", defaultValue: 20);

        public void Validate()
        {
        }
    }
}
