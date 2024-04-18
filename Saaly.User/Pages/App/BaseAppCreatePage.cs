using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Saaly.Data;
using Saaly.Models;
using Saaly.Models.Bases;
using Saaly.Shared.Interfaces;

namespace Saaly.User.Pages.App
{
    public abstract class BaseAppCreatePage<T> : BaseAppPage<T>
        where T : SaalyBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private SaalyContext _context;


        public BaseAppCreatePage(UserManager<ApplicationUser> userManager, IUrlHelper urlHelper,
            SaalyContext context) : base(userManager, urlHelper, context)
        {
            _userManager = userManager;
            _context = context;

        }

        [BindProperty]
        public T Model { get; set; }

        public virtual IActionResult OnGet()
        {
            return Page();
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            await _entity.AddAsync(Model);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

        public IWebUIRequest AdminRequest { get; set; }
    }
}