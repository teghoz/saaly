using Saaly.Models;
using Saaly.Models.EntityModels;

namespace Saaly.Data.Repositories
{
    public class EntityBillCodeEFRepository : AbstractEFRepository<EntityBillCode>
    {
        private readonly SaalyContext _context;

        public EntityBillCodeEFRepository(SaalyContext context) : base(context)
        {
            _context = context;
        }
    }
}