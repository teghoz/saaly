using Microsoft.AspNetCore.Authentication.Cookies;

namespace Saaly.Infrastructure.Extensions
{
    public class CustomIdentityOption
    {
        public bool IsProduction { get; set; }
        public string ConnectionString { get; set; }
        public string LoginPath { get; set; }
        public string AccessDeniedPath { get; set; }
        public string CookieName { get; set; }
        public Action<CookieAuthenticationOptions> AuthenticationOptions { get; set; }
    }
}
