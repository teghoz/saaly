using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Saaly.Data;
using Saaly.Models;
using Saaly.Models.Bases;
using Saaly.Shared.Interfaces;
using Saaly.Shared.TagHelpers;

namespace Saaly.User.Pages.App
{
    public abstract class BaseAppDeletePage<T> : BaseAppPage<T>
        where T : SaalyBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUrlHelper _urlHelper;
        private SaalyContext _context;


        public BaseAppDeletePage(UserManager<ApplicationUser> userManager, IUrlHelper urlHelper,
            SaalyContext context) : base(userManager, urlHelper, context)
        {
            _userManager = userManager;
            _urlHelper = urlHelper;
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
            
            BreadCrumbs = new CrumbList();
            BreadCrumbs.Items = new List<ListItem>
            {
                new()
                {
                    Label = "Dashboard",
                    HasLink = true,
                    Order = 0,
                    Url = _urlHelper.Page("/App/Index", new { entityGuid = EntityGuid })
                },
                new()
                {
                    Label = GetPageName(PageContext.ActionDescriptor.DisplayName),
                    HasLink = true,
                    Order = 1,
                    Url = _urlHelper.Page($"/App/{GetPageName(PageContext.ActionDescriptor.DisplayName)}/Index", new { EntityGuid })
                },
                new()
                {
                    Label = "Delete",
                    HasAriaCurrent = true,
                    Order = 2
                }
            };
            
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

            return RedirectToPage("./Index", new { EntityGuid });
        }

        public IWebUIRequest? AdminRequest { get; set; }
    }
}