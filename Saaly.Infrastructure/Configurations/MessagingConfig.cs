namespace Saaly.Infrastucture.Configurations
{
    public class MessagingConfig : IConfig
    {
        public string? RegistrationQueue => ConfigHelper.Instance.GetValueFromAppSettings("Messaging:Queues:RegistrationQueue", defaultValue: "registration-queue-dev");
        public string? BrevoAPIKey => ConfigHelper.Instance.GetValueFromAppSettings("Messaging:Mailers:Brevo:APIKey", defaultValue: "");
        public string? RabbitConnection => ConfigHelper.Instance.GetValueFromAppSettings("Messaging:Rabbit:Host", defaultValue: "");
        public string? RabbitUsername => ConfigHelper.Instance.GetValueFromAppSettings("Messaging:Rabbit:Username", defaultValue: "");
        public string? RabbitPassword => ConfigHelper.Instance.GetValueFromAppSettings("Messaging:Rabbit:Password", defaultValue: "");
        public string? RabbitVirtualHost => ConfigHelper.Instance.GetValueFromAppSettings("Messaging:Rabbit:VirtualHost", defaultValue: "/");
        public int RabbitPort => ConfigHelper.Instance.GetValueFromAppSettings("Messaging:Rabbit:Port", defaultValue: 5670);
        public void Validate()
        {
        }
    }
}
