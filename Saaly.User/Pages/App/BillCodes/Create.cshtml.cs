using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Saaly.Data;
using Saaly.Models;
using Saaly.Models.EntityModels;
using Saaly.Services.Entity.BillCodes;
using Saaly.Services.Entity.BillUnits;
using Saaly.Services.Entity.Currencies;
using Saaly.Services.Requests;
using Saaly.Shared.Extensions;

namespace Saaly.User.Pages.App.BillCodes
{
    public class CreateModel : BaseAppCreatePage<EntityBillCode>
    {
        private readonly ILogger _logger;
        private readonly SaalyContext _context;
        private readonly IEntityBillCodeService _entityBillCodeService;
        private readonly IEntityBillUnitService _entityBillUnitService;
        private readonly IEntityCurrencyService _entityCurrencyService;

        public CreateModel(ILogger<IndexModel> logger, SaalyContext context, 
            UserManager<ApplicationUser> userManager, IEntityBillCodeService entityBillCodeService,
            IEntityBillUnitService entityBillUnitService, IEntityCurrencyService entityCurrencyService)
            : base(userManager, context)
        {
            _logger = logger;
            _context = context;
            _entityBillCodeService = entityBillCodeService;
            _entityBillUnitService = entityBillUnitService;
            _entityCurrencyService = entityCurrencyService;
        }
        
        public async Task<IActionResult> OnGetAsync()
        {
            var billUnits = await _entityBillUnitService.GetBillUnits(EntityGuid, null, null);
            ViewData["BillUnits"] = billUnits.MorphToDropdownOptions(b => b.Guid, u => u.Name);

            var currencies = await _entityCurrencyService.GetCurrencies(EntityGuid, null, null);
            ViewData["Currencies"] = currencies.MorphToDropdownOptions(b => b.Guid, u => u.Name);
            
            return Page();
        }

        public override async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _entity == null || Model == null)
            {
                return Page();
            }

            var billCodeRequest = new EntityBillCodeRequest
            {
                EntityGuid = EntityGuid,
                IsActive = Model.IsActive,
                Name = Model.Name,
                CurrencyRates = Model.CurrencyRates
            };
            await _entityBillCodeService.AddBillCode(billCodeRequest);
            return RedirectToPage("./Index");
        }
    }
}