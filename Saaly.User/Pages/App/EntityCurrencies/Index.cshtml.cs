using Microsoft.AspNetCore.Identity;
using Saaly.Data;
using Saaly.Models;
using Saaly.Models.EntityModels;
using Saaly.Services.Entity;
using Saaly.Services.Entity.BillCodes;
using Saaly.Services.Entity.Currencies;
using X.PagedList;

namespace Saaly.User.Pages.App.EntityCurrencies
{
    public class IndexModel : BaseAppPage<EntityCurrency>
    {
        private readonly ILogger _logger;
        private readonly SaalyContext _context;
        private readonly IEntityCurrencyService _entityCurrencyService;

        public IndexModel(ILogger<IndexModel> logger, SaalyContext context, UserManager<ApplicationUser> userManager, IEntityCurrencyService entityCurrencyService)
            : base(userManager, context)
        {
            _logger = logger;
            _context = context;
            _entityCurrencyService = entityCurrencyService;
        }

        public async Task OnGetAsync()
        {
            var result = await _entityCurrencyService.GetCurrencies(EntityGuid, QuerySkip, Take);
            ModelList = await result.ToPagedListAsync(PaginationSkip, Take.Value, EntityCount);
        }
    }
}