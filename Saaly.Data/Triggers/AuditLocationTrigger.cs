using EntityFrameworkCore.Triggered;
using Saaly.Models.Audits;
using Saaly.Models.EntityModels;

namespace Saaly.Data.Triggers
{
    public class AuditLocationTrigger : IAfterSaveTrigger<Location>
    {
        readonly SaalyContext _context;
        public AuditLocationTrigger(SaalyContext context)
        {
            _context = context;
        }

        public async Task AfterSave(ITriggerContext<Location> context, CancellationToken cancellationToken)
        {
            var audit = new AuditLocation
            {
                IsActive = true,
                Created = context.Entity.Created,
                Modified = context.Entity.Modified,
                CreatedByUser = context.Entity.CreatedByUser,
                ModifiedByUser = context.Entity.ModifiedByUser,
                Deleted = context.Entity.Deleted,
                DeletedByUser = context.Entity.DeletedByUser,
                Depth = context.Entity.Depth,
                LocationGuid = context.Entity.Guid,
                MapData = context.Entity.MapData,
                ParentGuid = context.Entity.ParentGuid,
                Slug = context.Entity.Slug,
                SortOrder = context.Entity.SortOrder,
                Title = context.Entity.Title
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

            await _context.AuditLocations.AddAsync(audit);
            await _context.SaveChangesAsync();
        }

        public void AfterSave(ITriggerContext<Location> context)
        {
            throw new NotImplementedException();
        }
    }

}
