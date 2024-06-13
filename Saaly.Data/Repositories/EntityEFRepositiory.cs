using Saaly.Models.EntityModels;

namespace Saaly.Data.Repositories
{
    public class EntityEFRepositiory : AbstractEFRepository<Entity>
    {
        private readonly SaalyContext _context;

        public EntityEFRepositiory(SaalyContext context) : base(context)
        {
            _context = context;
        }
    }
}