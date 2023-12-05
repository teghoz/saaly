using Microsoft.EntityFrameworkCore;
using SaalyModels;

namespace Saaly.Data
{
    public partial class SaalyContext
    {
        public DbSet<AuditEntityTask> AuditEntityTask { get; set; }
    }
}
