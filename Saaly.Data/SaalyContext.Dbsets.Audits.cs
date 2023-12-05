using Microsoft.EntityFrameworkCore;
using Saaly.Models.Audits;

namespace Saaly.Data
{
    public partial class SaalyContext
    {
        public DbSet<AuditEntityTask> AuditEntityTask { get; set; }
    }
}
