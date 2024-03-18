using Microsoft.AspNetCore.Identity;
using Saaly.Data;
using Saaly.Models;
using Saaly.Services.Admin;
using Saaly.Services.Requests;
using X.PagedList;

namespace Saaly.Pages.Admins
{
    public class IndexModel : BasePage<Admin>
    {
        private readonly ILogger _logger;
        private readonly SaalyContext _context;
        private readonly IAdminService _adminService;

        public IndexModel(ILogger<IndexModel> logger, SaalyContext context, UserManager<ApplicationUser> userManager, IAdminService adminService)
            : base(userManager, context)
        {
            _logger = logger;
            _context = context;
            _adminService = adminService;
        }

        public async Task OnGetAsync()
        {
            var request = new AdminRequest(SearchTerm = SearchTerm, QuerySkip, Take);
            var result = await _adminService.GetAdmin(request);

            ModelList = await result.ToPagedListAsync(PaginationSkip, Take.Value, EntityCount);
        }
    }
}