using Microsoft.AspNetCore.Identity;
using Saaly.Data;
using Saaly.Models;
using Saaly.Services.Entity;
using X.PagedList;

namespace Saaly.User.Pages.App.Entities
{
    public class IndexModel : BasePage<Models.EntityModels.Entity>
    {
        private readonly ILogger _logger;
        private readonly SaalyContext _context;
        private readonly IEntityService _entityService;

        public IndexModel(ILogger<IndexModel> logger, SaalyContext context, UserManager<ApplicationUser> userManager, IEntityService entityService)
            : base(userManager, context)
        {
            _logger = logger;
            _context = context;
            _entityService = entityService;
        }

        public async Task OnGetAsync()
        {
            var result = await _entityService.GetUserEntities(ApplicationUser.UserGuid.Value, QuerySkip, Take);

            ModelList = await result.ToPagedListAsync(PaginationSkip, Take.Value, EntityCount);
        }
    }
}