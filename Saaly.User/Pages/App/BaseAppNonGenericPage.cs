using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Primitives;
using Saaly.Data;
using Saaly.Models;
using Saaly.Shared.TagHelpers;

namespace Saaly.User.Pages.App
{
    public abstract class BaseAppNonGenericPage : BaseUserNonGenericPage
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUrlHelper _urlHelper;
        private SaalyContext _context;

        public BaseAppNonGenericPage(UserManager<ApplicationUser> userManager,
            IUrlHelper urlHelper, SaalyContext context): base(userManager, context)
        {
            _userManager = userManager;
            _urlHelper = urlHelper;
            _context = context;
        }
        public ApplicationUser? ApplicationUser { get; set; }
        public string? BaseUrl { get; set; }
        public string? ShareMessage { get; set; }
        [TempData]
        public string? MessageStr { get; set; }
        public Guid EntityGuid { get; set; }
        public CrumbList BreadCrumbs { get; set; }

        public override async Task OnPageHandlerSelectionAsync(PageHandlerSelectedContext context)
        {
            if (!context.HttpContext.User.IsInRole("User") ||
                !context.HttpContext.User.Identity.IsAuthenticated)
            {
                RedirectToPage("/Account/Login", new { area = "Identity" });
            }

            BaseUrl = $"{Request.Scheme}://{Request.Host}{Request.PathBase}";

            if (EntityGuid == Guid.Empty)
            {
                Guid.TryParse(context.HttpContext.Request.RouteValues["entityGuid"].ToString(), out Guid entityGuid);
                EntityGuid = entityGuid;

                if (EntityGuid == Guid.Empty)
                {
                    RedirectToPage("/Entities", new { area = "/" });
                }                   
            }

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
                context.Result = RedirectToPage("/Account/Login", new { area = "Identity" });
            }
            else if (EntityGuid == Guid.Empty)
            {
                Guid.TryParse(context.HttpContext.Request.RouteValues["entityGuid"].ToString(), out Guid entityGuid);
                EntityGuid = entityGuid;

                if (EntityGuid == Guid.Empty)
                {
                    RedirectToPage("/Entities", new { area = "/" });
                }
            }
            else
            {
                var page = context.HandlerInstance as PageModel;
                if (page == null) return;
                if (ApplicationUser is not null)
                {
                    page.ViewData["AuthenticatedUser"] = ApplicationUser.UserName;
                }
                //page.ViewData["AuthenticatedUserLastName"] = Admin?.Contact?.LastName ?? "";
                page.ViewData["entityGuid"] = EntityGuid;
                page.ViewData["Host"] = context.HttpContext.Request.Host.Host;
                SetTitleAndActivePage(page);
                
                BreadCrumbs = new CrumbList();
                BreadCrumbs.Items = new List<ListItem>
                {
                    new ListItem
                    {
                        Label = "Dashboard",
                        HasLink = true,
                        Order = 0,
                        Url = _urlHelper.Page("/App/Index", new { entityGuid = EntityGuid})
                    },
                    new ListItem
                    {
                        Label = GetPageName(page.PageContext.ActionDescriptor.DisplayName),
                        HasLink = true,
                        Order = 1,
                        Url = _urlHelper.Page(page.PageContext.ActionDescriptor.DisplayName, new { EntityGuid })
                    }
                };
                var resultContext = await next();
            }
        }

        public string GetPageName(string pagePath)
        {
            var pathSplits = pagePath.Split("/").ToList();
            if (pathSplits.Contains("App") && pathSplits.Count >= 3)
            {
                return pathSplits[2];
            }

            return string.Empty;
        }

        private void SetTitleAndActivePage(PageModel page)
        {
            switch (page.PageContext.ActionDescriptor.DisplayName)
            {
                case var name when name.Contains("Index"):
                    page.ViewData["Title"] = GetPageName(name) + " List";
                    page.ViewData[$"Is{GetPageName(name)}Active"] = "active";
                    break;
                case var name when name.Contains("Create"):
                    page.ViewData["Title"] = $@"Create {GetPageName(name)}";
                    page.ViewData[$"Is{GetPageName(name)}Active"] = "active";
                    break;
                case var name when name.Contains("Edit"):
                    page.ViewData["Title"] = $@"Edit {GetPageName(name)}";
                    page.ViewData[$"Is{GetPageName(name)}Active"] = "active";
                    break;
                case var name when name.Contains("Delete"):
                    page.ViewData["Title"] = $@"Delete {GetPageName(name)}";
                    page.ViewData[$"Is{GetPageName(name)}Active"] = "active";
                    break;
                case var name when name.Contains("Details"):
                    page.ViewData["Title"] = $@"{GetPageName(name)} Details";
                    page.ViewData[$"Is{GetPageName(name)}Active"] = "active";
                    break;
            }
            
        }
    }
}
