using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saaly.Infrastucture.Configurations
{
    public class DatabaseConfig : IConfig
    {
        //public int NumberOfQouteAnSPCanSend => ConfigHelper.Instance.GetValueFromAppSettings("ServiceProvider:NumberOfQouteAnSPCanSend", defaultValue: 10);
        public string? ConnectionString => ConfigHelper.Instance.GetValueFromAppSettings("ConnectionString", defaultValue: "Data Source=localhost,1433;initial catalog=YoodaloOne;User ID=sa;Password=T@gh0z2017;MultipleActiveResultSets=True;Persist Security Info=true;App=EntityFramework;Trust Server Certificate=true");

        public void Validate()
        {
        }
    }
}
