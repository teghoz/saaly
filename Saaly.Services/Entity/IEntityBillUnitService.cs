using Saaly.Models.EntityModels;
using Saaly.Services.Requests;

namespace Saaly.Services.Entity;

public interface IEntityBillUnitService
{
    Task<List<EntityBillUnit>?> GetBillUnits(Guid entityGuid, int? skip, int? take);
    Task<EntityBillUnit?> GetBillUnit(Guid entityGuid, Guid billUnitGuid);
    Task<EntityBillUnit> AddBillUnit(EntityBillUnitRequest request);
    Task RemoveBillUnit(EntityBillUnit billUnit);
}