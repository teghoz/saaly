using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Saaly.Data;
using Saaly.Models;
using Saaly.Models.EntityModels;
using Saaly.Services.Entity.BillCodes;
using X.PagedList;

namespace Saaly.User.Pages.App.BillCodes
{
    public class IndexModel : BaseAppPage<EntityBillCode>
    {
        private readonly ILogger _logger;
        private readonly SaalyContext _context;
        private readonly IEntityBillCodeService _entityBillCodeService;

        public IndexModel(ILogger<IndexModel> logger, SaalyContext context, UserManager<ApplicationUser> userManager,
            IEntityBillCodeService entityBillCodeService, IUrlHelper urlHelper)
            : base(userManager, urlHelper, context)
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