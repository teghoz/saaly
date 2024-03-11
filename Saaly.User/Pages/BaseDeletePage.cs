using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Saaly.Data;
using Saaly.Models;
using Saaly.Models.Bases;
using Saaly.Shared.Interfaces;

namespace Saaly.User.Pages
{
    public abstract class BaseDeletePage<T> : BasePage<T>
        where T : SaalyBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private SaalyContext _context;


        public BaseDeletePage(UserManager<ApplicationUser> userManager,
            SaalyContext context) : base(userManager, context)
        {
            _userManager = userManager;
            _context = context;

        }

        [BindProperty]
        public T? Model { get; set; }

        public virtual async Task<IActionResult> OnGetAsync(Guid? guid)
        {
            if (guid == null)
            {
                return NotFound();
            }

            Model = await _entity.FirstOrDefaultAsync(m => m.Guid == guid);

            if (Model == null)
            {
                return NotFound();
            }
            return Page();
        }

        public virtual async Task<IActionResult> OnPostAsync(Guid? guid)
        {
            if (guid == null)
            {
                return NotFound();
            }

            Model = await _entity.FindAsync(guid);

            if (Model != null)
            {
                _entity.Remove(Model);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }

        public IWebUIRequest? AdminRequest { get; set; }
    }
}