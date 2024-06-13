using Saaly.Models;
using Saaly.Models.EntityModels;

namespace Saaly.Data.Repositories
{
    public class EntityBillUnitEFRepository : AbstractEFRepository<EntityBillUnit>
    {
        private readonly SaalyContext _context;

        public EntityBillUnitEFRepository(SaalyContext context) : base(context)
        {
            _context = context;
        }
    }
}