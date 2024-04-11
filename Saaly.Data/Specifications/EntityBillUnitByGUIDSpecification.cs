using Ardalis.Specification;
using Saaly.Models.EntityModels;

namespace Saaly.Data.Specifications
{
    public class EntityBillUnitByGUIDSpecification : EntityPagingSpecification<EntityBillUnit>
    {
        public EntityBillUnitByGUIDSpecification(Guid entityGuid, Guid billUnitGuid, int? skip = 0, int? page = 20) : base(entityGuid, skip, page)
        {
            Query.Where(u => u.Guid == billUnitGuid);
        }
    }
}
