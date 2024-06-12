using Saaly.Models.EntityModels;
using Saaly.Services.Requests;

namespace Saaly.Services.Entity.Clients;

public interface IEntityClientService
{
    Task<List<EntityClient>?> GetClients(Guid entityGuid, int? skip, int? take);
    Task<EntityClient?> GetClient(Guid entityGuid, Guid billUnitGuid);
    Task<EntityClient> AddClient(EntityClientRequest request, CancellationToken cancellationToken);
    Task UpdateClient(EntityClient client, CancellationToken cancellationToken);
    Task RemoveClient(EntityClient client, CancellationToken cancellationToken);
}