using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Saaly.Data;
using Saaly.Models;
using Saaly.Models.EntityModels;
using Saaly.Services.Entity.Currencies;

namespace Saaly.User.Pages.App.Currencies
{
    public class EditModel : BaseAppEditPage<EntityCurrency>
    {
        private readonly ILogger _logger;
        private readonly SaalyContext _context;
        private readonly IEntityCurrencyService _entityCurrencyService;

        public EditModel(ILogger<EditModel> logger, SaalyContext context, IEntityCurrencyService entityCurrencyService,
            UserManager<ApplicationUser> userManager)
            : base(userManager, context)
        {
            _logger = logger;
            _context = context;
            _entityCurrencyService = entityCurrencyService;
        }

        public override async Task<IActionResult> OnGetAsync(Guid? guid)
        {
            if (guid == Guid.Empty)
            {
                return NotFound();
            }

            Model = await _entityCurrencyService.GetCurrency(EntityGuid, guid.Value);

            if (Model == null)
            {
                return NotFound();
            }


            return Page();
        }

        public override async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Model).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ModelExists(Model.Guid))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }
    }
}