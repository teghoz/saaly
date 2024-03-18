using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Saaly.Data;
using Saaly.Models;

namespace Saaly.User.Pages.App.Entities
{
    public class CreateModel : BaseCreatePage<Admin>
    {
        private readonly ILogger _logger;
        private readonly SaalyContext _context;

        public CreateModel(ILogger<IndexModel> logger, SaalyContext context, UserManager<ApplicationUser> userManager)
            : base(userManager, context)
        {
            _logger = logger;
            _context = context;
        }

        public override async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _entity == null || Model == null)
            {
                return Page();
            }

            await _context.Admins.AddAsync(Model);
            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");
        }
    }
}