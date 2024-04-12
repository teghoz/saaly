using Ardalis.Specification;
using Saaly.Models.Bases;

namespace Saaly.Data.Specifications
{
    public abstract class EntityPagingSpecification<T> : PagingSpecification<T> where T : EntityBase
    {
        public EntityPagingSpecification(Guid entityGuid, int? skip, int? take): base(skip, take)
        {
            Query.Where(e => e.EntityGuid == entityGuid);
        }
    }
}
