using Microsoft.AspNetCore.Identity;
using Saaly.Data;
using Saaly.Models;
using Saaly.Services.Entity;
using Saaly.Services.Entity.BillUnits;
using X.PagedList;

namespace Saaly.User.Pages.App.EntityBillUnits
{
    public class IndexModel : BaseAppPage<Models.EntityModels.EntityBillUnit>
    {
        private readonly ILogger _logger;
        private readonly SaalyContext _context;
        private readonly IEntityBillUnitService _entityBillUnitService;

        public IndexModel(ILogger<IndexModel> logger, SaalyContext context, UserManager<ApplicationUser> userManager, IEntityBillUnitService entityBillUnitService)
            : base(userManager, context)
        {
            _logger = logger;
            _context = context;
            _entityBillUnitService = entityBillUnitService;
        }

        public async Task OnGetAsync()
        {
            var result = await _entityBillUnitService.GetBillUnits(EntityGuid, QuerySkip, Take);
            ModelList = await result.ToPagedListAsync(PaginationSkip, Take.Value, EntityCount);
        }
    }
}