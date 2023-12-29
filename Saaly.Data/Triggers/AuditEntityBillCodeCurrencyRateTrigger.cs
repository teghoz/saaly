using EntityFrameworkCore.Triggered;
using Saaly.Models.Audits;
using Saaly.Models.EntityModels;

namespace Saaly.Data.Triggers
{
    public class AuditEntityBillCodeCurrencyRateTrigger : IAfterSaveTrigger<EntityBillCodeCurrencyRate>
    {
        readonly SaalyContext _context;
        public AuditEntityBillCodeCurrencyRateTrigger(SaalyContext context)
        {
            _context = context;
        }

        public async Task AfterSave(ITriggerContext<EntityBillCodeCurrencyRate> context, CancellationToken cancellationToken)
        {
            var audit = new AuditEntityBillCodeCurrencyRate
            {
                IsActive = true,
                Created = context.Entity.Created,
                Modified = context.Entity.Modified,
                CreatedByUser = context.Entity.CreatedByUser,
                ModifiedByUser = context.Entity.ModifiedByUser,
                EntityGuid = context.Entity.EntityGuid,
                Deleted = context.Entity.Deleted,
                DeletedByUser = context.Entity.DeletedByUser,
                EntityBillCodeGuid = context.Entity.Guid,
                BillCostRate = context.Entity.BillCostRate,
                EntityBillCodeCurrencyRateGuid = context.Entity.Guid,
                BillRate = context.Entity.BillRate,
                EntityCurrencyGuid = context.Entity.EntityCurrencyGuid
            };

            switch (context.ChangeType)
            {
                case ChangeType.Added:
                    audit.ChangeType = Models.Enums.eAuditChangeType.Added;
                    break;
                case ChangeType.Modified:
                    audit.ChangeType = Models.Enums.eAuditChangeType.Modified;
                    audit.Modified = context.Entity.Modified;
                    break;
                case ChangeType.Deleted:
                    audit.ChangeType = Models.Enums.eAuditChangeType.Deleted;
                    break;
            }

            await _context.AuditEntityBillCodeCurrencyRates.AddAsync(audit);
            await _context.SaveChangesAsync();
        }

        public void AfterSave(ITriggerContext<EntityBillCodeCurrencyRate> context)
        {
            throw new NotImplementedException();
        }
    }

}
