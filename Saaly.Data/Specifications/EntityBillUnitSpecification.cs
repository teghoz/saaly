using Saaly.Models.EntityModels;

namespace Saaly.Data.Specifications
{
    public class EntityBillUnitSpecification : EntityPagingSpecification<EntityBillUnit>
    {
        public EntityBillUnitSpecification(Guid entityGuid, int? skip, int? page) : base(entityGuid, skip, page)
        {
        }
    }
}
