using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Saaly.Data;
using Saaly.Models;
using Saaly.Models.EntityModels;
using Saaly.Services.Entity;
using Saaly.Services.Entity.BillUnits;
using Saaly.Services.Entity.Clients;
using X.PagedList;

namespace Saaly.User.Pages.App.Clients
{
    public class IndexModel : BaseAppPage<EntityClient>
    {
        private readonly ILogger _logger;
        private readonly SaalyContext _context;
        private readonly IEntityClientService _entityClientService;

        public IndexModel(ILogger<IndexModel> logger, SaalyContext context, UserManager<ApplicationUser> userManager,
            IEntityClientService entityClientService, IUrlHelper urlHelper)
            : base(userManager, urlHelper, context)
        {
            _logger = logger;
            _context = context;
            _entityClientService = entityClientService;
        }

        public async Task OnGetAsync()
        {
            var result = await _entityClientService.GetClients(EntityGuid, QuerySkip, Take);
            ModelList = await result.ToPagedListAsync(PaginationSkip, Take.Value, EntityCount);
        }
    }
}