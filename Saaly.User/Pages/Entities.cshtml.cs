using Humanizer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Saaly.Data;
using Saaly.Models;
using Saaly.Models.EntityModels;
using Saaly.Services.Entity;
using SaalyShared.Enums;
using X.PagedList;

namespace Saaly.User.Pages
{
    public class EntitiesModel : BasePage<Models.EntityModels.Entity>
    {
        private readonly SaalyContext _context;
        private readonly ILogger<IndexModel> _logger;
        private readonly IEntityService _entityService;

        public EntitiesModel(UserManager<ApplicationUser> userManager,
            SaalyContext context, ILogger<IndexModel> logger, IEntityService entityService) : base(userManager, context)
        {
            _context = context;
            _logger = logger;
            _entityService = entityService;
        }

        [BindProperty]
        public Entity Entity { get; set; }

        public async Task OnGetAsync()
        {
            var result = await _entityService.GetUserEntities(ApplicationUser.UserGuid.Value, QuerySkip, Take);

            ViewData["EntityTypes"] = new SelectList(GetEntityTypes(), "Value", "Text").Prepend(new SelectListItem("Please Select", ""));

            ModelList = await result.ToPagedListAsync(PaginationSkip, Take.Value, EntityCount);
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var request = new NewEntityRequest
            {
                Type = Entity.Type,
                Name = Entity.Name,
                Status = Entity.IsActive
            };

            await _entityService.AddEntity(request);

            return RedirectToPage("./Entities");
        }

        private List<SelectListItem> GetEntityTypes()
        {
            return Enum.GetValues(typeof(eEntityTypes))
                .Cast<eEntityTypes>()
                .OrderBy(c => c)
                .Select(c => new SelectListItem { Text = c.Humanize(), Value = ((int)c).ToString() })
                .ToList();
        }
    }
}