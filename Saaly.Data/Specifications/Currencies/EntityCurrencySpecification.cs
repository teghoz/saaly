using Saaly.Models.EntityModels;

namespace Saaly.Data.Specifications.Currencies
{
    public class EntityCurrencySpecification : EntityPagingSpecification<EntityCurrency>
    {
        public EntityCurrencySpecification(Guid entityGuid, int? skip, int? page) : base(entityGuid, skip, page)
        {
        }
    }
}
