using Microsoft.AspNetCore.Identity;
using Saaly.Data;
using Saaly.Models;

namespace Saaly.User.Pages.App
{
    public class IndexModel : BaseUserNonGenericPage
    {
        private readonly SaalyContext _context;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(UserManager<ApplicationUser> userManager,
            SaalyContext context, ILogger<IndexModel> logger) : base(userManager, context)
        {
            _context = context;
            _logger = logger;
        }

        public async Task OnGet(Guid entityGuid)
        {

        }
    }
}