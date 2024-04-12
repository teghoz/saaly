using Saaly.Models.EntityModels;

namespace Saaly.Data.Specifications.BillUnits
{
    public class EntityBillUnitSpecification : EntityPagingSpecification<EntityBillUnit>
    {
        public EntityBillUnitSpecification(Guid entityGuid, int? skip, int? page) : base(entityGuid, skip, page)
        {
        }
    }
}
