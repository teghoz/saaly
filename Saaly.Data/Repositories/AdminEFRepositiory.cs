using Saaly.Models;

namespace Saaly.Data.Repositories
{
    public class AdminEFRepositiory : AbstractEFRepository<Admin>
    {
        private readonly SaalyContext _context;

        public AdminEFRepositiory(SaalyContext context) : base(context)
        {
            _context = context;
        }
    }
}