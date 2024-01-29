namespace Saaly.Infrastucture.Configurations
{
    public class MessagingConfig : IConfig
    {
        public string? RegistrationQueue => ConfigHelper.Instance.GetValueFromAppSettings("Messaging:Queues:RegistrationQueue", defaultValue: "queue:registration-queue-dev");
        public void Validate()
        {
        }
    }
}
