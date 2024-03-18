using Saaly.Models;
using Saaly.Models.EntityModels;

namespace Saaly.Data.Repositories
{
    public class EntityUserEFRepositiory : AbstractEFRepository<EntityUser>
    {
        private readonly SaalyContext _context;

        public EntityUserEFRepositiory(SaalyContext context) : base(context)
        {
            _context = context;
        }
    }
}