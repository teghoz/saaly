using Saaly.Data;
using Saaly.Data.Interfaces;
using Saaly.Data.Specifications;
using Saaly.Models.EntityModels;
using Saaly.Services.Requests;

namespace Saaly.Services.Entity;

public class EntityBillCodeService : IEntityBillCodeService
{
    private readonly SaalyContext _saalyContext;
    private readonly IRepository<EntityBillCode> _entityBillCodeRepository;

    public EntityBillCodeService(SaalyContext saalyContext,
        IRepository<EntityBillCode> entityBillCodeRepository)
    {
        _saalyContext = saalyContext;
        _entityBillCodeRepository = entityBillCodeRepository;
    }
    
    public async Task<List<EntityBillCode>?> GetBillCodes(Guid entityGuid, int? skip, int? take)
    {
        var spec = new EntityBillCodeSpecification(entityGuid, skip, take);
        return await _entityBillCodeRepository.GetAll(spec);
    }
    
    public async Task<EntityBillCode?> GetBillCode(Guid entityGuid, Guid billCodeGuid)
    {
        var spec = new EntityBillCodeByGUIDSpecification(entityGuid, billCodeGuid);
        var model = await _entityBillCodeRepository.GetAll(spec);
        return model.FirstOrDefault();
    }
    
    public async Task<EntityBillCode> AddBillCode(EntityBillCodeRequest request)
    {
        var model = new EntityBillCode
        {
            EntityGuid = request.EntityGuid,
            IsActive = request.IsActive,
            Created = DateTime.UtcNow,
            Name = request.Name,
            CurrencyRates = request.CurrencyRates
        };

        await _saalyContext.EntityBillCodes.AddAsync(model);
        await _saalyContext.SaveChangesAsync();
        return model;
    }
    
    public async Task RemoveBillCode(EntityBillCode billCode)
    {
        _saalyContext.EntityBillCodes.Remove(billCode);
        await _saalyContext.SaveChangesAsync();
    }
}