using Saaly.Models.EntityModels;
using Saaly.Services.Requests;

namespace Saaly.Services.Entity.BillCodes;

public interface IEntityBillCodeService
{
    Task<List<EntityBillCode>?> GetBillCodes(Guid entityGuid, int? skip, int? take);
    Task<EntityBillCode?> GetBillCode(Guid entityGuid, Guid billCodeGuid);
    Task<EntityBillCode> AddBillCode(EntityBillCodeRequest request, CancellationToken cancellationToken);
    Task UpdateBillCode(EntityBillCode billCode, CancellationToken cancellationToken);
    Task RemoveBillCode(EntityBillCode billCode, CancellationToken cancellationToken);
}