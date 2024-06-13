using Saaly.Data;
using Saaly.Data.Interfaces;
using Saaly.Data.Specifications.BillUnits;
using Saaly.Data.Specifications.Clients;
using Saaly.Models.EntityModels;
using Saaly.Services.Requests;

namespace Saaly.Services.Entity.Clients;

public class EntityClientService : IEntityClientService
{
    private readonly SaalyContext _saalyContext;
    private readonly IRepository<EntityClient> _entityClientRepository;

    public EntityClientService(SaalyContext saalyContext,
        IRepository<EntityClient> entityClientRepository)
    {
        _saalyContext = saalyContext;
        _entityClientRepository = entityClientRepository;
    }
    
    public async Task<List<EntityClient>?> GetClients(Guid entityGuid, int? skip, int? take)
    {
        var spec = new EntityClientSpecification(entityGuid, skip, take);
        return await _entityClientRepository.GetAll(spec);
    }
    
    public async Task<EntityClient?> GetClient(Guid entityGuid, Guid billUnitGuid)
    {
        var spec = new EntityClientByGUIDSpecification(entityGuid, billUnitGuid);
        var model = await _entityClientRepository.GetAll(spec);
        return model.FirstOrDefault();
    }

    public async Task<EntityClient> AddClient(EntityClientRequest request, CancellationToken cancellationToken)
    {
        var model = new EntityClient
        {
            EntityGuid = request.EntityGuid,
            IsActive = request.IsActive,
            Created = DateTime.UtcNow,
            Name = request.Name,
            Contact = request.Contact,
            ManagementCompany = request.ManagementCompany
        };

        await _saalyContext.EntityClients.AddAsync(model, cancellationToken);
        await _saalyContext.SaveChangesAsync(cancellationToken);
        return model;
    }

    public async Task UpdateClient(EntityClient client, CancellationToken cancellationToken)
    {
        _saalyContext.EntityClients.Update(client);
        await _saalyContext.SaveChangesAsync(cancellationToken);
    }
    
    public async Task RemoveClient(EntityClient client, CancellationToken cancellationToken)
    {
        _saalyContext.EntityClients.Remove(client);
        await _saalyContext.SaveChangesAsync(cancellationToken);
    }
}