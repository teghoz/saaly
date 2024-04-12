using Saaly.Models;
using Saaly.Models.EntityModels;

namespace Saaly.Data.Repositories
{
    public class EntityBillUnitEFRepositiory : AbstractEFRepository<EntityBillUnit>
    {
        private readonly SaalyContext _context;

        public EntityBillUnitEFRepositiory(SaalyContext context) : base(context)
        {
            _context = context;
        }
    }
}