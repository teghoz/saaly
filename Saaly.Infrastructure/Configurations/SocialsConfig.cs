using Saaly.Infrastucture.Configurations;

namespace Saaly.Infrastructure.Configurations
{
    public class SocialsConfig : IConfig
    {
        public string? GoogleRecaptchaSiteKey => ConfigHelper.Instance.GetValueFromAppSettings("Socials:GoogleRecaptchaSiteKey", defaultValue: "");
        public string? GoogleRecaptchaSecretKey => ConfigHelper.Instance.GetValueFromAppSettings("Socials:GoogleRecaptchaSecretKey", defaultValue: "");
        public string? GoogleSiteVerification => ConfigHelper.Instance.GetValueFromAppSettings("Socials:GoogleSiteVerification", defaultValue: "");
        public string? GoogleMeasurementID => ConfigHelper.Instance.GetValueFromAppSettings("Socials:GoogleMeasurementID", defaultValue: "G-RHW7ZBN8X1");
        public string? GoogleMapApiKey => ConfigHelper.Instance.GetValueFromAppSettings("Socials:GoogleMapApiKey", defaultValue: "");
        public string? VansoServerUrl => ConfigHelper.Instance.GetValueFromAppSettings("Messaging:VansoServerUrl", defaultValue: "http://sxmp.gw1.vanso.com");
        public string? GoogleAuthenticationClientID => ConfigHelper.Instance.GetValueFromAppSettings("Authentication:Google:ClientId", defaultValue: "");
        public string? GoogleAuthenticationClientSecret => ConfigHelper.Instance.GetValueFromAppSettings("Authentication:Google:ClientSecret", defaultValue: "");

        public void Validate()
        {
        }
    }
}
