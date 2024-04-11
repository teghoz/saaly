using Microsoft.AspNetCore.Identity;
using Saaly.Data;
using Saaly.Models;
using Saaly.Services.Entity;
using X.PagedList;

namespace Saaly.User.Pages.App.EntityBillCodes
{
    public class IndexModel : BaseAppPage<Models.EntityModels.EntityBillCode>
    {
        private readonly ILogger _logger;
        private readonly SaalyContext _context;
        private readonly IEntityBillCodeService _entityBillCodeService;

        public IndexModel(ILogger<IndexModel> logger, SaalyContext context, UserManager<ApplicationUser> userManager, IEntityBillCodeService entityBillCodeService)
            : base(userManager, context)
        {
            _logger = logger;
            _context = context;
            _entityBillCodeService = entityBillCodeService;
        }

        public async Task OnGetAsync()
        {
            var result = await _entityBillCodeService.GetBillCodes(EntityGuid, QuerySkip, Take);
            ModelList = await result.ToPagedListAsync(PaginationSkip, Take.Value, EntityCount);
        }
    }
}