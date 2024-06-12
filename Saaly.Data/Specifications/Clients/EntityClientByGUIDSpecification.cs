using Ardalis.Specification;
using Saaly.Models.EntityModels;

namespace Saaly.Data.Specifications.Clients
{
    public class EntityClientByGUIDSpecification : EntityPagingSpecification<EntityClient>
    {
        public EntityClientByGUIDSpecification(Guid entityGuid, Guid clientGuid, int? skip = 0, int? page = 20) : base(entityGuid, skip, page)
        {
            Query.Where(u => u.Guid == clientGuid);
        }
    }
}
