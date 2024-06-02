using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Saaly.Data;
using Saaly.Models;
using Saaly.Models.EntityModels;

namespace Saaly.User.Pages.App.BillUnits
{
    public class DeleteModel : BaseAppDeletePage<EntityBillUnit>
    {
        private readonly SaalyContext _context;

        public DeleteModel(SaalyContext context, UserManager<ApplicationUser> userManager, IUrlHelper urlHelper)
            : base(userManager, urlHelper, context)
        {
            _context = context;
        }
    }
}
