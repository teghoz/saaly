using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Saaly.Data;
using Saaly.Models;
using Saaly.Models.EntityModels;

namespace Saaly.User.Pages.App.Clients
{
    public class EditModel : BaseAppEditPage<EntityClient>
    {
        private readonly ILogger _logger;
        private readonly SaalyContext _context;

        public EditModel(ILogger<IndexModel> logger, SaalyContext context,
            UserManager<ApplicationUser> userManager, IUrlHelper urlHelper)
            : base(userManager, urlHelper, context)
        {
            _logger = logger;
            _context = context;
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
                if (!(await ModelExists(Model.Guid)))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index", new { EntityGuid });
        }
    }
}