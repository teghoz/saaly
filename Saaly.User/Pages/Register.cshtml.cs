using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SaalyUser.Pages
{
    public class RegisterModel : PageModel
    {
        private readonly ILogger _logger;

        public RegisterModel(ILogger<RegisterModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}