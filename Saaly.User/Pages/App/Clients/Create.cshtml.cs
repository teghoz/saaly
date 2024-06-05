using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Saaly.Data;
using Saaly.Models;
using Saaly.Models.EntityModels;
using Saaly.Services.Entity.Clients;
using Saaly.Services.Requests;

namespace Saaly.User.Pages.App.Clients
{
    public class CreateModel : BaseAppCreatePage<EntityClient>
    {
        private readonly ILogger _logger;
        private readonly SaalyContext _context;
        private readonly IEntityClientService _entityClientService;

        public CreateModel(ILogger<IndexModel> logger, SaalyContext context,
            UserManager<ApplicationUser> userManager, IUrlHelper urlHelper,
            IEntityClientService entityClientService)
            : base(userManager, urlHelper, context)
        {
            _logger = logger;
            _context = context;
            _entityClientService = entityClientService;
        }
        
        public override async Task<IActionResult> OnGetAsync()
        {
            Model = new EntityClient
            {
                Contact = new Contact(),
                Name = null
            };
            return Page();
        }

        public override async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _entity == null || Model == null)
            {
                return Page();
            }

            var clientRequest = new EntityClientRequest
            {
                EntityGuid = EntityGuid,
                IsActive = Model.IsActive,
                Name = Model.Name
            };

            await _entityClientService.AddClient(clientRequest);
            return RedirectToPage("./Index", new { entityGuid = EntityGuid });
        }
    }
}