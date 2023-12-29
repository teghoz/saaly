using EntityFrameworkCore.Triggered;
using Saaly.Models.Audits;
using Saaly.Models.EntityModels;

namespace Saaly.Data.Triggers
{
    public class AuditEntityClientGroupTrigger : IAfterSaveTrigger<EntityClientGroup>
    {
        readonly SaalyContext _context;
        public AuditEntityClientGroupTrigger(SaalyContext context)
        {
            _context = context;
        }

        public async Task AfterSave(ITriggerContext<EntityClientGroup> context, CancellationToken cancellationToken)
        {
            var audit = new AuditEntityClientGroup
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
                Code = context.Entity.Code,
                Description = context.Entity.Description,
                EntityClientGroupGuid = context.Entity.Guid,
                HasMaximumCapacity = context.Entity.HasMaximumCapacity,
                MaximumCapacity = context.Entity.MaximumCapacity
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

            await _context.AuditEntityClientGroups.AddAsync(audit);
            await _context.SaveChangesAsync();
        }

        public void AfterSave(ITriggerContext<EntityClientGroup> context)
        {
            throw new NotImplementedException();
        }
    }

}
