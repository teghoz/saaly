using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Saaly.Data;
using Saaly.Models;

namespace Saaly.User.Pages.App
{
    public class IndexModel : BaseAppNonGenericPage
    {
        private readonly SaalyContext _context;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(UserManager<ApplicationUser> userManager, IUrlHelper urlHelper,
            SaalyContext context, ILogger<IndexModel> logger) : base(userManager, urlHelper, context)
        {
            _context = context;
            _logger = logger;
        }

        public async Task OnGet()
        {
        }
    }
}