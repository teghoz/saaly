using Saaly.Models.EntityModels;
using Saaly.Services.Requests;

namespace Saaly.Services.Entity.Clients;

public interface IEntityClientService
{
    Task<List<EntityClient>?> GetClients(Guid entityGuid, int? skip, int? take);
    Task<EntityClient?> GetClient(Guid entityGuid, Guid billUnitGuid);
    Task<EntityClient> AddClient(EntityClientRequest request);
    Task UpdateClient(EntityClient client);
    Task RemoveClient(EntityClient client);
}