using Ardalis.Specification;
using Saaly.Models.EntityModels;

namespace Saaly.Data.Specifications.BillCodes
{
    public class EntityBillCodeByGUIDSpecification : EntityPagingSpecification<EntityBillCode>
    {
        public EntityBillCodeByGUIDSpecification(Guid entityGuid, Guid billCodeGuid, int? skip, int? page) : base(entityGuid, skip, page)
        {
            Query.Where(u => u.Guid == billCodeGuid);
        }
    }
}
