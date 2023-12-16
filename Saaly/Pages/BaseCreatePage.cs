using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Saaly.Data;
using Saaly.Infrastucture.Configurations;
using Saaly.Models;
using Saaly.Models.Bases;
using Saaly.Shared.Interfaces;

namespace Saaly.Pages
{
    public abstract class BaseCreatePage<T> : BasePage<T>
        where T : SaalyBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private SaalyContext _context;


        public BaseCreatePage(UserManager<ApplicationUser> userManager,
            SaalyContext context) : base(userManager, context)
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
            _entity.Add(Model);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

        public IWebUIRequest AdminRequest { get; set; }
    }
}