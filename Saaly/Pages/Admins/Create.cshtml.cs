using Microsoft.AspNetCore.Identity;
using Saaly.Data;
using Saaly.Models;

namespace Saaly.Pages.Admins
{
    public class CreateModel : BaseCreatePage<Admin>
    {
        private readonly ILogger _logger;
        private readonly SaalyContext _context;

        public CreateModel(ILogger<IndexModel> logger, SaalyContext context, UserManager<ApplicationUser> userManager)
            : base(userManager, context)
        {
            _logger = logger;
            _context = context;
        }
    }
}