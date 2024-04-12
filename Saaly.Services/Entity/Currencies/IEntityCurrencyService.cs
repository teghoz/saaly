using Saaly.Models.EntityModels;
using Saaly.Services.Requests;

namespace Saaly.Services.Entity.Currencies;

public interface IEntityCurrencyService
{
    Task<List<EntityCurrency>?> GetCurrencies(Guid entityGuid, int? skip, int? take);
    Task<EntityCurrency?> GetCurrency(Guid entityGuid, Guid currencyGuid);
    Task<EntityCurrency> AddCurrency(EntityCurrencyRequest request);
    Task UpdateCurrency(EntityCurrency currency);
    Task RemoveCurrency(EntityCurrency currency);
}