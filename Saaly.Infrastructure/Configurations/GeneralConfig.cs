using Saaly.Infrastucture.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
