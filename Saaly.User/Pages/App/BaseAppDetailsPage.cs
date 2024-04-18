using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Saaly.Data;
using Saaly.Models;
using Saaly.Models.Bases;
using Saaly.Shared.Interfaces;

namespace Saaly.User.Pages.App
{
    public abstract class BaseAppDetailsPage<T> : BaseAppPage<T>
        where T : SaalyBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private SaalyContext _context;

        public BaseAppDetailsPage(UserManager<ApplicationUser> userManager, IUrlHelper urlHelper,
            SaalyContext context) : base(userManager, urlHelper, context)
        {
            _userManager = userManager;
            _context = context;
        }

        [BindProperty]
        public T? Model { get; set; }

        public virtual async Task<IActionResult> OnGetAsync(Guid? guid)
        {
            if (guid == Guid.Empty)
            {
                return NotFound();
            }

            Model = await _entity.AsQueryable().FirstOrDefaultAsync(m => m.Guid == guid);

            if (Model == null)
            {
                return NotFound();
            }
            return Page();
        }

        public IWebUIRequest? AdminRequest { get; set; }
    }
}