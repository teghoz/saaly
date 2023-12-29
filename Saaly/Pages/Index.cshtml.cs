using Microsoft.AspNetCore.Identity;
using Saaly.Data;
using Saaly.Models;

namespace Saaly.Pages
{
    public class IndexModel : BaseNonGenericPage
    {
        private readonly ILogger _logger;
        private readonly SaalyContext _context;

        public IndexModel(ILogger<IndexModel> logger, SaalyContext context, UserManager<ApplicationUser> userManager)
            : base(userManager, context)
        {
            _logger = logger;
            _context = context;
        }

        public void OnGet()
        {

        }
    }
}