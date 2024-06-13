using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Saaly.Data;
using Saaly.Models;
using Saaly.Models.EntityModels;
using Saaly.User.Pages.App;

namespace Saaly.User.Pages.App.Currencies
{
    public class DetailsModel : BaseAppDetailsPage<EntityCurrency>
    {
        private readonly SaalyContext _context;

        public DetailsModel(SaalyContext context, UserManager<ApplicationUser> userManager, IUrlHelper urlHelper)
            : base(userManager, urlHelper, context)
        {
            _context = context;
        }
    }
}
