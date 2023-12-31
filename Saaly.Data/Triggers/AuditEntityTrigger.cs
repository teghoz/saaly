﻿using EntityFrameworkCore.Triggered;
using Saaly.Models.Audits;
using Saaly.Models.EntityModels;

namespace Saaly.Data.Triggers
{
    public class AuditEntityTrigger : IAfterSaveTrigger<Entity>
    {
        readonly SaalyContext _context;
        public AuditEntityTrigger(SaalyContext context)
        {
            _context = context;
        }

        public async Task AfterSave(ITriggerContext<Entity> context, CancellationToken cancellationToken)
        {
            var audit = new AuditEntity
            {
                IsActive = true,
                Created = context.Entity.Created,
                Modified = context.Entity.Modified,
                CreatedByUser = context.Entity.CreatedByUser,
                ModifiedByUser = context.Entity.ModifiedByUser,
                EntityGuid = context.Entity.Guid,
                Deleted = context.Entity.Deleted,
                DeletedByUser = context.Entity.DeletedByUser,
                Types = context.Entity.Types,
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

            await _context.AuditEntities.AddAsync(audit);
            await _context.SaveChangesAsync();
        }

        public void AfterSave(ITriggerContext<Entity> context)
        {
            throw new NotImplementedException();
        }
    }

}
