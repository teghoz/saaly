using Ardalis.Specification;
using Saaly.Models.Bases;
using Saaly.Models.EntityModels;

namespace Saaly.Data.Specifications
{
    public class EntityBaseSpecification : Specification<EntityBase>
    {
        public EntityBaseSpecification(Guid entityGuid)
        {
            Query.Where(e => e.EntityGuid == entityGuid);
        }
    }
}
