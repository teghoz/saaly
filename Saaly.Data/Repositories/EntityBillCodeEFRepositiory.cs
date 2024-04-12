using Saaly.Models;
using Saaly.Models.EntityModels;

namespace Saaly.Data.Repositories
{
    public class EntityBillCodeEFRepositiory : AbstractEFRepository<EntityBillCode>
    {
        private readonly SaalyContext _context;

        public EntityBillCodeEFRepositiory(SaalyContext context) : base(context)
        {
            _context = context;
        }
    }
}