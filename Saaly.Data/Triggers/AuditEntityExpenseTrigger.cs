using EntityFrameworkCore.Triggered;
using Saaly.Models.Audits;
using Saaly.Models.EntityModels;

namespace Saaly.Data.Triggers
{
    public class AuditEntityExpenseTrigger : IAfterSaveTrigger<EntityExpense>
    {
        readonly SaalyContext _context;
        public AuditEntityExpenseTrigger(SaalyContext context)
        {
            _context = context;
        }

        public async Task AfterSave(ITriggerContext<EntityExpense> context, CancellationToken cancellationToken)
        {
            var audit = new AuditEntityExpense
            {
                IsActive = true,
                Created = context.Entity.Created,
                Modified = context.Entity.Modified,
                CreatedByUser = context.Entity.CreatedByUser,
                ModifiedByUser = context.Entity.ModifiedByUser,
                EntityGuid = context.Entity.EntityGuid,
                Deleted = context.Entity.Deleted,
                DeletedByUser = context.Entity.DeletedByUser,
                Amount = context.Entity.Amount,
                ClientGuid = context.Entity.ClientGuid,
                Comments = context.Entity.Comments,
                Date = context.Entity.Date,
                Day = context.Entity.Day,
                EntityExpenseGuid = context.Entity.Guid,
                Type = context.Entity.Type,
                UserGuid = context.Entity.UserGuid,
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

            await _context.AuditEntityExpenses.AddAsync(audit);
            await _context.SaveChangesAsync();
        }

        public void AfterSave(ITriggerContext<EntityExpense> context)
        {
            throw new NotImplementedException();
        }
    }

}
