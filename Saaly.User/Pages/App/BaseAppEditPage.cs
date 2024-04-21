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
    public abstract class BaseAppEditPage<T> : BaseAppPage<T>
        where T : SaalyBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUrlHelper _urlHelper;
        private SaalyContext _context;


        public BaseAppEditPage(UserManager<ApplicationUser> userManager, IUrlHelper urlHelper,
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
            if (guid == Guid.Empty)
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
                    Label = "Edit",
                    HasAriaCurrent = true,
                    Order = 2
                }
            };
            
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public virtual async Task<IActionResult> OnPostAsync()
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

        public async Task<bool> ModelExists(Guid guid)
        {
            return await _entity.AnyAsync(e => e.Guid == guid);
        }

        public IWebUIRequest AdminRequest { get; set; }
    }
}