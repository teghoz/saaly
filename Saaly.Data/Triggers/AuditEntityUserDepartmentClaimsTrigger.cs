﻿using EntityFrameworkCore.Triggered;
using Saaly.Models.Audits;
using Saaly.Models.EntityModels;

namespace Saaly.Data.Triggers
{
    public class AuditEntityUserDepartmentClaimsTrigger : IAfterSaveTrigger<EntityUserDepartmentClaim>
    {
        readonly SaalyContext _context;
        public AuditEntityUserDepartmentClaimsTrigger(SaalyContext context)
        {
            _context = context;
        }

        public async Task AfterSave(ITriggerContext<EntityUserDepartmentClaim> context, CancellationToken cancellationToken)
        {
            var audit = new AuditEntityUserDepartmentClaim
            {
                IsActive = true,
                Created = context.Entity.Created,
                Modified = context.Entity.Modified,
                CreatedByUser = context.Entity.CreatedByUser,
                ModifiedByUser = context.Entity.ModifiedByUser,
                EntityGuid = context.Entity.EntityGuid,
                Deleted = context.Entity.Deleted,
                DeletedByUser = context.Entity.DeletedByUser,
                EntityUserDepartmentGuid = context.Entity.EntityGuid,
                Name = context.Entity.Name,
                EntityUserDepartmentClaimGuid = context.Entity.Guid,
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

            await _context.AuditEntityUserDepartmentClaims.AddAsync(audit);
            await _context.SaveChangesAsync();
        }

        public void AfterSave(ITriggerContext<EntityUserDepartmentClaim> context)
        {
            throw new NotImplementedException();
        }
    }

}
