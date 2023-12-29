using EntityFrameworkCore.Triggered;
using Saaly.Models.Audits;
using Saaly.Models.EntityModels;

namespace Saaly.Data.Triggers
{
    public class AuditEntityClientTrigger : IAfterSaveTrigger<EntityClient>
    {
        readonly SaalyContext _context;
        public AuditEntityClientTrigger(SaalyContext context)
        {
            _context = context;
        }

        public async Task AfterSave(ITriggerContext<EntityClient> context, CancellationToken cancellationToken)
        {
            var audit = new AuditEntityClient
            {
                IsActive = true,
                Created = context.Entity.Created,
                Modified = context.Entity.Modified,
                CreatedByUser = context.Entity.CreatedByUser,
                ModifiedByUser = context.Entity.ModifiedByUser,
                EntityGuid = context.Entity.EntityGuid,
                Deleted = context.Entity.Deleted,
                DeletedByUser = context.Entity.DeletedByUser,
                Name = context.Entity.Name,
                ContactGuid = context.Entity.ContactGuid,
                EntityClientBillingInfoGuid = context.Entity.EntityClientBillingInfoGuid,
                EntityClientGuid = context.Entity.Guid,
                ManagementCompany = context.Entity.ManagementCompany
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

            await _context.AuditEntityClients.AddAsync(audit);
            await _context.SaveChangesAsync();
        }

        public void AfterSave(ITriggerContext<EntityClient> context)
        {
            throw new NotImplementedException();
        }
    }

}
