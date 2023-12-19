using EntityFrameworkCore.Triggered;
using Saaly.Models.Audits;
using Saaly.Models.EntityModels;

namespace Saaly.Data.Triggers
{
    public class AuditEntityBillCodeTrigger : IAfterSaveTrigger<EntityBillCode>
    {
        readonly SaalyContext _context;
        public AuditEntityBillCodeTrigger(SaalyContext context)
        {
            _context = context;
        }

        public async Task AfterSave(ITriggerContext<EntityBillCode> context, CancellationToken cancellationToken)
        {
            var audit = new AuditEntityBillCode
            {
                IsActive = true,
                Created = context.Entity.Created,
                Modified = context.Entity.Modified,
                CreatedByUser = context.Entity.CreatedByUser,
                ModifiedByUser = context.Entity.ModifiedByUser,
                EntityGuid = context.Entity.EntityGuid,
                Deleted = context.Entity.Deleted,
                DeletedByUser = context.Entity.DeletedByUser,
                BillUnitGuid = context.Entity.BillUnitGuid,
                Description = context.Entity.Description,
                EntityBillCodeGuid = context.Entity.Guid,
                Name = context.Entity.Name,
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

            await _context.AuditEntityBillCodes.AddAsync(audit);
            await _context.SaveChangesAsync();
        }

        public void AfterSave(ITriggerContext<EntityBillCode> context)
        {
            throw new NotImplementedException();
        }
    }

}
