using Saaly.Infrastucture.Configurations;

namespace Saaly.Infrastructure.Configurations
{
    public class PasswordConfig : IConfig
    {
        public int MinimumPasswordLength => ConfigHelper.Instance.GetValueFromAppSettings("Password:MinimumPasswordLength", defaultValue: 5);
        public string AllowedCharacters => ConfigHelper.Instance.GetValueFromAppSettings("Password:AllowedCharacters", defaultValue: "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+");
        public string TokenSecret => ConfigHelper.Instance.GetValueFromAppSettings("Password:AllowedCharacters", defaultValue: "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+");
        public int MaximumFailedAttempts => ConfigHelper.Instance.GetValueFromAppSettings("Password:MaximumFailedAttempts", defaultValue: 5);
        public int RequireUniqueCharacters => ConfigHelper.Instance.GetValueFromAppSettings("Password:RequireUniqueCharacters", defaultValue: 1);
        public int DefaultLockedTimespan => ConfigHelper.Instance.GetValueFromAppSettings("Password:DefaultLockedTimespan", defaultValue: 5);
        public bool RequireUpperCase => ConfigHelper.Instance.GetValueFromAppSettings<bool>("Password:RequireUpperCase", defaultValue: false);
        public bool RequireDigit => ConfigHelper.Instance.GetValueFromAppSettings<bool>("Password:RequireDigit", defaultValue: true);
        public bool RequireLowerCase => ConfigHelper.Instance.GetValueFromAppSettings<bool>("Password:RequireLowerCase", defaultValue: false);
        public bool RequireNonAlphaNumeric => ConfigHelper.Instance.GetValueFromAppSettings<bool>("Password:RequireNonAlphaNumeric", defaultValue: false);
        public bool SendConfirmationEmailOnForgotPassword => ConfigHelper.Instance.GetValueFromAppSettings<bool>("Password:SendConfirmationEmailOnForgotPassword", defaultValue: true);

        public void Validate()
        {
        }
    }
}
