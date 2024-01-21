using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Saaly.Infrastucture.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saaly.Services.Recaptcha
{
    public class RecaptchaService : ICaptchaService
    {
        private readonly ILogger<RecaptchaService> _logger;
        private readonly IHttpClientFactory _httpClientFactory;

        public RecaptchaService(ILogger<RecaptchaService> logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _httpClientFactory = httpClientFactory;
        }
        public async Task<bool> Verify(string encodedResponse)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(SaalyConfig.Instance.Socials.GoogleRecaptchaSiteKey) || string.IsNullOrWhiteSpace(SaalyConfig.Instance.Socials.GoogleRecaptchaSecretKey))
                    return true;

                var client = _httpClientFactory.CreateClient();
                var response = await client.GetStringAsync($"https://www.google.com/recaptcha/api/siteverify?secret={SaalyConfig.Instance.Socials.GoogleRecaptchaSecretKey}&response={encodedResponse}");
                var captcha = JsonConvert.DeserializeObject<ReCaptchaResponse>(response);

                return captcha.Success;

            }
            catch (Exception err)
            {
                _logger.LogError(err, err.Message);
                return false;
            }
        }
    }
}
