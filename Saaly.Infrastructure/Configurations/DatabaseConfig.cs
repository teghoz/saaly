﻿namespace Saaly.Infrastucture.Configurations
{
    public class DatabaseConfig : IConfig
    {
        //public int NumberOfQouteAnSPCanSend => ConfigHelper.Instance.GetValueFromAppSettings("ServiceProvider:NumberOfQouteAnSPCanSend", defaultValue: 10);
        public string? ConnectionString => ConfigHelper.Instance.GetValueFromAppSettings("ConnectionString", defaultValue: "Host=localhost,5432;Database=Saaly;Username=postgres;Password=T@gh0z2017");

        public void Validate()
        {
        }
    }
}
