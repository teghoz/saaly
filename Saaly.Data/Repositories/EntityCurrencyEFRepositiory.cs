using Saaly.Models;
using Saaly.Models.EntityModels;

namespace Saaly.Data.Repositories
{
    public class EntityCurrencyEFRepositiory : AbstractEFRepository<EntityCurrency>
    {
        private readonly SaalyContext _context;

        public EntityCurrencyEFRepositiory(SaalyContext context) : base(context)
        {
            _context = context;
        }
    }
}