using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Saaly.Data;
using Saaly.Models;

namespace Saaly.User.Pages
{
    public abstract class BaseNonGenericPage : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private SaalyContext _context;

        public BaseNonGenericPage(UserManager<ApplicationUser> userManager,
            SaalyContext context)
        {
            _userManager = userManager;
            _context = context;
        }
        public ApplicationUser? ApplicationUser { get; set; }
        public string BaseUrl { get; set; }
        public string ShareMessage { get; set; }
        [TempData]
        public string MessageStr { get; set; }

        public override async Task OnPageHandlerSelectionAsync(PageHandlerSelectedContext context)
        {
            if (!context.HttpContext.User.IsInRole("User") ||
                !context.HttpContext.User.Identity.IsAuthenticated)
            {
                RedirectToPage("Account/Login", new { area = "Identity" });
            }

            BaseUrl = $"{Request.Scheme}://{Request.Host}{Request.PathBase}";

            if (User != null)
            {
                var user = await _userManager.GetUserAsync(User);
                if (user != null)
                {
                    ApplicationUser = user;

                    await base.OnPageHandlerSelectionAsync(context);
                }
            }
        }

        public override async Task OnPageHandlerExecutionAsync(PageHandlerExecutingContext context, PageHandlerExecutionDelegate next)
        {
            // Called asynchronously before the handler method is invoked, after model binding is complete.
            if (!context.HttpContext.User.IsInRole("User") ||
                !context.HttpContext.User.Identity.IsAuthenticated)
            {
                context.Result = RedirectToPage("Account/Login", new { area = "Identity" });
            }
            else
            {
                var page = context.HandlerInstance as PageModel;
                if (page == null) return;
                page.ViewData["AuthenticatedUser"] = ApplicationUser.UserName;
                //page.ViewData["AuthenticatedUserLastName"] = Admin?.Contact?.LastName ?? "";
                page.ViewData["Host"] = context.HttpContext.Request.Host.Host;
                var resultContext = await next();
            }
        }
    }
}
