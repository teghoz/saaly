using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Saaly.Data;
using Saaly.Models;
using Saaly.Models.EntityModels;
using Saaly.Services.Entity.BillUnits;
using Saaly.Services.Requests;

namespace Saaly.User.Pages.App.BillUnits
{
    public class CreateModel : BaseAppCreatePage<EntityBillUnit>
    {
        private readonly ILogger _logger;
        private readonly SaalyContext _context;
        private readonly IEntityBillUnitService _entityBillUnitService;

        public CreateModel(ILogger<IndexModel> logger, SaalyContext context,
            UserManager<ApplicationUser> userManager, IUrlHelper urlHelper,
            IEntityBillUnitService entityBillUnitService)
            : base(userManager, urlHelper, context)
        {
            _logger = logger;
            _context = context;
            _entityBillUnitService = entityBillUnitService;
        }

        public override async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _entity == null || Model == null)
            {
                return Page();
            }

            var billUnitRequest = new EntityBillUnitRequest
            {
                EntityGuid = EntityGuid,
                IsActive = Model.IsActive,
                Name = Model.Name,
                Description = Model.Description
            };

            await _entityBillUnitService.AddBillUnit(billUnitRequest);
            return RedirectToPage("./Index", new { entityGuid = EntityGuid });
        }
    }
}