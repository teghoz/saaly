using Saaly.Models;
using Saaly.Models.EntityModels;

namespace Saaly.Data.Repositories
{
    public class EntityClientEFRepository : AbstractEFRepository<EntityClient>
    {
        private readonly SaalyContext _context;

        public EntityClientEFRepository(SaalyContext context) : base(context)
        {
            _context = context;
        }
    }
}