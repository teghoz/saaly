using EntityFrameworkCore.Triggered;
using Saaly.Models.Audits;
using Saaly.Models.EntityModels;

namespace Saaly.Data.Triggers
{
    public class AuditEntityWorkAssignmentTrigger : IAfterSaveTrigger<EntityWorkAssignment>
    {
        readonly SaalyContext _context;
        public AuditEntityWorkAssignmentTrigger(SaalyContext context)
        {
            _context = context;
        }

        public async Task AfterSave(ITriggerContext<EntityWorkAssignment> context, CancellationToken cancellationToken)
        {
            var audit = new AuditEntityWorkAssignment
            {
                IsActive = true,
                Created = context.Entity.Created,
                Modified = context.Entity.Modified,
                CreatedByUser = context.Entity.CreatedByUser,
                ModifiedByUser = context.Entity.ModifiedByUser,
                EntityGuid = context.Entity.EntityGuid,
                Deleted = context.Entity.Deleted,
                DeletedByUser = context.Entity.DeletedByUser,
                EntityUserGuid = context.Entity.Guid,
                AssigmentDate = context.Entity.AssigmentDate,
                AssignedHours = context.Entity.AssignedHours,
                EntityWorkAssignmentGuid = context.Entity.Guid,
                IsAssigned = context.Entity.IsAssigned,
                EndDate = context.Entity.EndDate,
                JobGuid = context.Entity.JobGuid,
                JobName = context.Entity.JobName,
                StartDate = context.Entity.StartDate,
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

            await _context.AuditEntityWorkAssignments.AddAsync(audit);
            await _context.SaveChangesAsync();
        }

        public void AfterSave(ITriggerContext<EntityWorkAssignment> context)
        {
            throw new NotImplementedException();
        }
    }

}
