using Saaly.Models.EntityModels;

namespace Saaly.Data.Specifications.BillCodes
{
    public class EntityBillCodeSpecification : EntityPagingSpecification<EntityBillCode>
    {
        public EntityBillCodeSpecification(Guid entityGuid, int? skip, int? page) : base(entityGuid, skip, page)
        {
        }
    }
}
