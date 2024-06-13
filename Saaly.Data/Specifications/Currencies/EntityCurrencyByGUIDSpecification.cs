using Ardalis.Specification;
using Saaly.Models.EntityModels;

namespace Saaly.Data.Specifications.Currencies
{
    public class EntityCurrencyByGUIDSpecification : EntityPagingSpecification<EntityCurrency>
    {
        public EntityCurrencyByGUIDSpecification(Guid entityGuid, Guid currencyGuid, int? skip = 0, int? page = 20) : base(entityGuid, skip, page)
        {
            Query.Where(u => u.Guid == currencyGuid);
        }
    }
}
