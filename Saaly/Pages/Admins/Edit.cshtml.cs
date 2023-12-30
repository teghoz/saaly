using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Saaly.Data;
using Saaly.Models;

namespace Saaly.Pages.Admins
{
    public class EditModel : BaseEditPage<Admin>
    {
        private readonly ILogger _logger;
        private readonly SaalyContext _context;

        public EditModel(ILogger<IndexModel> logger, SaalyContext context, UserManager<ApplicationUser> userManager)
            : base(userManager, context)
        {
            _logger = logger;
            _context = context;
        }

        public override async Task<IActionResult> OnGetAsync(Guid? guid)
        {
            if (guid == Guid.Empty)
            {
                return NotFound();
            }

            Model = await _context.Admins
                .Include(a => a.Contact)
                .FirstOrDefaultAsync(m => m.Guid == guid);

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

            _context.Attach(Admin).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ModelExists(Admin.Guid))
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