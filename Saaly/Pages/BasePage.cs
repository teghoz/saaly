using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Saaly.Data;
using Saaly.Infrastucture.Configurations;
using Saaly.Models;
using Saaly.Models.Bases;
using X.PagedList;

namespace Saaly.Pages
{
    public abstract class BasePage<T> : BaseNonGenericPage where T : SaalyBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private SaalyContext _context;
        public DbSet<T> _entity;

        public BasePage(UserManager<ApplicationUser> userManager,
            SaalyContext context) : base(userManager, context)
        {
            _userManager = userManager;
            _context = context;
            _entity = _context.Set<T>();
            EntityCount = _entity.CountAsync().Result;
        }
        public IPagedList<T> ModelList { get; set; }
        public int EntityCount { get; set; }
        public int PaginationSkip
        {
            get => Skip.Value == 0 ? 1 : Skip.Value;
        }

        public int QuerySkip
        {
            get => (Skip.Value - 1 < 0 ? 0 : Skip.Value - 1) * Take.Value;
        }
        [BindProperty(SupportsGet = true)] public int? Skip { get; set; } = 1;
        [BindProperty(SupportsGet = true)] public int? Take { get; set; } = SaalyConfig.Instance.General.DefaultPageCount;
        [BindProperty(SupportsGet = true)] public string? SearchTerm { get; set; } = string.Empty;
    }
}
