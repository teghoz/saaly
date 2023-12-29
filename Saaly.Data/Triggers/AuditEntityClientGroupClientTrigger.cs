using EntityFrameworkCore.Triggered;
using Saaly.Models.Audits;
using Saaly.Models.EntityModels;

namespace Saaly.Data.Triggers
{
    public class AuditEntityClientGroupClientTrigger : IAfterSaveTrigger<EntityClientGroupClient>
    {
        readonly SaalyContext _context;
        public AuditEntityClientGroupClientTrigger(SaalyContext context)
        {
            _context = context;
        }

        public async Task AfterSave(ITriggerContext<EntityClientGroupClient> context, CancellationToken cancellationToken)
        {
            var audit = new AuditEntityClientGroupClient
            {
                IsActive = true,
                Created = context.Entity.Created,
                Modified = context.Entity.Modified,
                CreatedByUser = context.Entity.CreatedByUser,
                ModifiedByUser = context.Entity.ModifiedByUser,
                ClientGuid = context.Entity.ClientGuid,
                Deleted = context.Entity.Deleted,
                DeletedByUser = context.Entity.DeletedByUser,
                EntityClientGroupClientGuid = context.Entity.ClientGuid,
                GroupGuid = context.Entity.GroupGuid,
            };

            switch (context.ChangeType)
            {
                case ChangeType.Added:
                    audit.ChangeType = Models.Enums.eAuditChangeType.Added;
                    break;
                case ChangeType.Modified:
                    audit.ChangeType = Models.Enums.eAuditChangeType.Modified;
                    audit.Modified = DateTime.UtcNow;
                    break;
                case ChangeType.Deleted:
                    audit.ChangeType = Models.Enums.eAuditChangeType.Deleted;
                    break;
            }

            await _context.AuditEntityClientGroupClients.AddAsync(audit);
            await _context.SaveChangesAsync();
        }

        public void AfterSave(ITriggerContext<EntityClientGroupClient> context)
        {
            throw new NotImplementedException();
        }
    }

}
