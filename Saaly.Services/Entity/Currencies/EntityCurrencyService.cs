using Saaly.Data;
using Saaly.Data.Interfaces;
using Saaly.Data.Specifications;
using Saaly.Data.Specifications.BillUnits;
using Saaly.Data.Specifications.Currencies;
using Saaly.Models.EntityModels;
using Saaly.Services.Requests;

namespace Saaly.Services.Entity.Currencies;

public class EntityCurrencyService : IEntityCurrencyService
{
    private readonly SaalyContext _saalyContext;
    private readonly IRepository<EntityCurrency> _entityCurrencyRepository;

    public EntityCurrencyService(SaalyContext saalyContext,
        IRepository<EntityCurrency> entityCurrencyRepository)
    {
        _saalyContext = saalyContext;
        _entityCurrencyRepository = entityCurrencyRepository;
    }
    
    public async Task<List<EntityCurrency>?> GetCurrencies(Guid entityGuid, int? skip, int? take)
    {
        var spec = new EntityCurrencySpecification(entityGuid, skip, take);
        return await _entityCurrencyRepository.GetAll(spec);
    }
    
    public async Task<EntityCurrency?> GetCurrency(Guid entityGuid, Guid currencyGuid)
    {
        var spec = new EntityCurrencyByGUIDSpecification(entityGuid, currencyGuid);
        var model = await _entityCurrencyRepository.GetAll(spec);
        return model.FirstOrDefault();
    }

    public async Task<EntityCurrency> AddCurrency(EntityCurrencyRequest request)
    {
        var model = new EntityCurrency
        {
            EntityGuid = request.EntityGuid,
            IsActive = request.IsActive,
            Created = DateTime.UtcNow,
            Name = request.Name,
            FractionalUnit = request.FractionalUnit,
            FullName = request.FullName,
            ShortName = request.ShortName,
            Symbol = request.Symbol,
        };

        await _saalyContext.EntityCurrencies.AddAsync(model);
        await _saalyContext.SaveChangesAsync();
        return model;
    }

    public async Task UpdateCurrency(EntityCurrency currency)
    {
        _saalyContext.EntityCurrencies.Update(currency);
        await _saalyContext.SaveChangesAsync();
    }
    
    public async Task RemoveCurrency(EntityCurrency currency)
    {
        _saalyContext.EntityCurrencies.Remove(currency);
        await _saalyContext.SaveChangesAsync();
    }
}