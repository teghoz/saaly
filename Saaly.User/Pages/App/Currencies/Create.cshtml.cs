using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Saaly.Data;
using Saaly.Models;
using Saaly.Models.EntityModels;
using Saaly.Services.Entity.BillCodes;
using Saaly.Services.Entity.Currencies;
using Saaly.Services.Requests;

namespace Saaly.User.Pages.App.Currencies
{
    public class CreateModel : BaseAppCreatePage<EntityCurrency>
    {
        private readonly ILogger _logger;
        private readonly SaalyContext _context;
        private readonly IEntityCurrencyService _entityCurrencyService;

        public CreateModel(ILogger<IndexModel> logger, SaalyContext context, 
            UserManager<ApplicationUser> userManager, IEntityCurrencyService entityCurrencyService)
            : base(userManager, context)
        {
            _logger = logger;
            _context = context;
            _entityCurrencyService = entityCurrencyService;
        }

        public override async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _entity == null || Model == null)
            {
                return Page();
            }

            var currencyRequest = new EntityCurrencyRequest
            {
                EntityGuid = EntityGuid,
                IsActive = Model.IsActive,
                Name = Model.Name,
                FractionalUnit = Model.FractionalUnit,
                FullName = Model.FullName,
                ShortName = Model.ShortName,
            };
            await _entityCurrencyService.AddCurrency(currencyRequest);
            return RedirectToPage("./Index");
        }
    }
}