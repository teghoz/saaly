using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Saaly.Data;
using Saaly.Infrastructure.Extensions;
using Saaly.Infrastucture.Configurations;
using Saaly.Models;
using Saaly.Shared.Messages;
using Saaly.User.Pages;

namespace Saaly.User.Pages
{
    public class IndexModel : BaseNonGenericPage
    {
        private readonly SaalyContext _context;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(UserManager<ApplicationUser> userManager,
            SaalyContext context, ILogger<IndexModel> logger) : base(userManager, context)
        {
            _context = context;
            _logger = logger;
        }

        public async Task OnGet()
        {

        }
    }
}