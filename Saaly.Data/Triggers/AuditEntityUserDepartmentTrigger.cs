using EntityFrameworkCore.Triggered;
using Saaly.Models.Audits;
using Saaly.Models.EntityModels;

namespace Saaly.Data.Triggers
{
    public class AuditEntityUserDepartmentTrigger : IAfterSaveTrigger<EntityUserDepartment>
    {
        readonly SaalyContext _context;
        public AuditEntityUserDepartmentTrigger(SaalyContext context)
        {
            _context = context;
        }

        public async Task AfterSave(ITriggerContext<EntityUserDepartment> context, CancellationToken cancellationToken)
        {
            var audit = new AuditEntityUserDepartment
            {
                IsActive = true,
                Created = context.Entity.Created,
                Modified = context.Entity.Modified,
                CreatedByUser = context.Entity.CreatedByUser,
                ModifiedByUser = context.Entity.ModifiedByUser,
                EntityGuid = context.Entity.EntityGuid,
                Deleted = context.Entity.Deleted,
                DeletedByUser = context.Entity.DeletedByUser,
                Code = context.Entity.Code,
                Description = context.Entity.Description,
                EntityUserDepartmentGuid = context.Entity.EntityGuid,
                Name = context.Entity.Name
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

            await _context.AuditEntityUserDepartments.AddAsync(audit);
            await _context.SaveChangesAsync();
        }

        public void AfterSave(ITriggerContext<EntityUserDepartment> context)
        {
            throw new NotImplementedException();
        }
    }

}
