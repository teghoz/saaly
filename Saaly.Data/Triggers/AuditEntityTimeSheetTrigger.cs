using EntityFrameworkCore.Triggered;
using Saaly.Models.Audits;
using Saaly.Models.EntityModels;

namespace Saaly.Data.Triggers
{
    public class AuditEntityTimeSheetTrigger : IAfterSaveTrigger<EntityTimeSheet>
    {
        readonly SaalyContext _context;
        public AuditEntityTimeSheetTrigger(SaalyContext context)
        {
            _context = context;
        }

        public async Task AfterSave(ITriggerContext<EntityTimeSheet> context, CancellationToken cancellationToken)
        {
            var audit = new AuditEntityTimeSheet
            {
                IsActive = true,
                Created = context.Entity.Created,
                Modified = context.Entity.Modified,
                CreatedByUser = context.Entity.CreatedByUser,
                ModifiedByUser = context.Entity.ModifiedByUser,
                EntityGuid = context.Entity.EntityGuid,
                Deleted = context.Entity.Deleted,
                DeletedByUser = context.Entity.DeletedByUser,
                AssigmentDate = context.Entity.AssigmentDate,
                ClientGuid = context.Entity.ClientGuid,
                Comments = context.Entity.Comments,
                Date = context.Entity.Date,
                Day = context.Entity.Day,
                EntityTimeSheetGuid = context.Entity.Guid,
                Status = context.Entity.Status,
                UserId = context.Entity.UserId,
                WorkedHours = context.Entity.WorkedHours,
                WorkGuid = context.Entity.WorkGuid,
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

            await _context.AuditEntityTimeSheet.AddAsync(audit);
            await _context.SaveChangesAsync();
        }

        public void AfterSave(ITriggerContext<EntityTimeSheet> context)
        {
            throw new NotImplementedException();
        }
    }

}
