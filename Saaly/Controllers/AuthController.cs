using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Saaly.Models;

namespace Saaly.Controllers
{
    [Route("[controller]")]
    public class AuthController : Controller
    {
        private readonly ILogger _logger;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AuthController(ILogger<AuthController> logger,
        SignInManager<ApplicationUser> signInManager)
        {
            _logger = logger;
            _signInManager = signInManager;
        }

        [HttpGet("LogOut")]
        public async Task<ActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return Redirect("/");
        }
    }
}
