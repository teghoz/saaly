using Saaly.Models.EntityModels;

namespace Saaly.Data.Specifications.Clients
{
    public class EntityClientSpecification : EntityPagingSpecification<EntityClient>
    {
        public EntityClientSpecification(Guid entityGuid, int? skip, int? page) : base(entityGuid, skip, page)
        {
        }
    }
}
