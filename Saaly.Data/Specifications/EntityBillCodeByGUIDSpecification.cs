using Ardalis.Specification;
using Saaly.Models.EntityModels;

namespace Saaly.Data.Specifications
{
    public class EntityBillCodeByGUIDSpecification : EntityPagingSpecification<EntityBillCode>
    {
        public EntityBillCodeByGUIDSpecification(Guid entityGuid, Guid billCodeGuid, int? skip = 0, int? page = 20) : base(entityGuid, skip, page)
        {
            Query.Where(u => u.Guid == billCodeGuid);
        }
    }
}
