using Saaly.Models.EntityModels;
using Saaly.Services.Requests;

namespace Saaly.Services.Entity;

public interface IEntityBillCodeService
{
    Task<List<EntityBillCode>?> GetBillCodes(Guid entityGuid, int? skip, int? take);
    Task<EntityBillCode?> GetBillCode(Guid entityGuid, Guid billCodeGuid);
    Task<EntityBillCode> AddBillCode(EntityBillCodeRequest request);
    Task RemoveBillCode(EntityBillCode billCode);
}