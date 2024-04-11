using Saaly.Models.EntityModels;

namespace Saaly.Data.Specifications
{
    public class EntityBillCodeSpecification : EntityPagingSpecification<EntityBillCode>
    {
        public EntityBillCodeSpecification(Guid entityGuid, int? skip, int? page) : base(entityGuid, skip, page)
        {
        }
    }
}
