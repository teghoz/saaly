using Saaly.Data;
using Saaly.Data.Interfaces;
using Saaly.Data.Specifications.BillUnits;
using Saaly.Models.EntityModels;
using Saaly.Services.Requests;

namespace Saaly.Services.Entity.BillUnits;

public class EntityBillUnitService : IEntityBillUnitService
{
    private readonly SaalyContext _saalyContext;
    private readonly IRepository<EntityBillUnit> _entityBillUnitRepository;

    public EntityBillUnitService(SaalyContext saalyContext,
        IRepository<EntityBillUnit> entityBillCodeRepository)
    {
        _saalyContext = saalyContext;
        _entityBillUnitRepository = entityBillCodeRepository;
    }
    
    public async Task<List<EntityBillUnit>?> GetBillUnits(Guid entityGuid, int? skip, int? take)
    {
        var spec = new EntityBillUnitSpecification(entityGuid, skip, take);
        return await _entityBillUnitRepository.GetAll(spec);
    }
    
    public async Task<EntityBillUnit?> GetBillUnit(Guid entityGuid, Guid billUnitGuid)
    {
        var spec = new EntityBillUnitByGUIDSpecification(entityGuid, billUnitGuid);
        var model = await _entityBillUnitRepository.GetAll(spec);
        return model.FirstOrDefault();
    }

    public async Task<EntityBillUnit> AddBillUnit(EntityBillUnitRequest request)
    {
        var model = new EntityBillUnit
        {
            EntityGuid = request.EntityGuid,
            IsActive = request.IsActive,
            Created = DateTime.UtcNow,
            Name = request.Name,
            Description = request.Description
        };

        await _saalyContext.EntityBillUnits.AddAsync(model);
        await _saalyContext.SaveChangesAsync();
        return model;
    }

    public async Task UpdateBillUnit(EntityBillUnit billUnit)
    {
        _saalyContext.EntityBillUnits.Update(billUnit);
        await _saalyContext.SaveChangesAsync();
    }
    
    public async Task RemoveBillUnit(EntityBillUnit billUnit)
    {
        _saalyContext.EntityBillUnits.Remove(billUnit);
        await _saalyContext.SaveChangesAsync();
    }
}