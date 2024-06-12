using Saaly.Models.EntityModels;
using Saaly.Services.Requests;

namespace Saaly.Services.Entity.Currencies;

public interface IEntityCurrencyService
{
    Task<List<EntityCurrency>?> GetCurrencies(Guid entityGuid, int? skip, int? take);
    Task<EntityCurrency?> GetCurrency(Guid entityGuid, Guid currencyGuid);
    Task<EntityCurrency> AddCurrency(EntityCurrencyRequest request, CancellationToken cancellationToken);
    Task UpdateCurrency(EntityCurrency currency, CancellationToken cancellationToken);
    Task RemoveCurrency(EntityCurrency currency, CancellationToken cancellationToken);
}