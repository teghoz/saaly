using Ardalis.Specification;
using Saaly.Models.EntityModels;

namespace Saaly.Data.Specifications
{
    public class EntityByUserSpecification : PagingSpecification<EntityUser>
    {
        public EntityByUserSpecification(Guid entityUserGuid, int? skip, int? page) : base(skip, page)
        {
            Query
                .Include(a => a.Entity)
                .Where(a => a.UserGuid == entityUserGuid);
        }
    }
}
