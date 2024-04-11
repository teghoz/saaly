using Ardalis.Specification;
using Saaly.Models.Bases;

namespace Saaly.Data.Specifications
{
    public abstract class EntityPagingSpecification<T> : PagingSpecification<T> where T : EntityBase
    {
        public EntityPagingSpecification(Guid entityGuid, int? skip = 0, int? take = 20): base(skip, take)
        {
            Query
                .Where(e => e.EntityGuid == entityGuid)
                .Skip(skip.Value * take.Value)
                .Take(take.Value);
        }
    }
}
