using Microsoft.EntityFrameworkCore;
using Saaly.Models.Audits;

namespace Saaly.Data
{
    public partial class SaalyContext
    {
        public DbSet<AuditEntity> AuditEntities { get; set; }
        public DbSet<AuditEntityBillCode> AuditEntityBillCodes { get; set; }
        public DbSet<AuditEntityBillCodeCurrencyRate> AuditEntityBillCodeCurrencyRates { get; set; }
        public DbSet<AuditEntityBillUnit> AuditEntityBillUnits { get; set; }
        public DbSet<AuditEntityClient> AuditEntityClients { get; set; }
        public DbSet<AuditEntityClientBillingInfo> AuditEntityClientBillingInfos { get; set; }
        public DbSet<AuditEntityClientGroup> AuditEntityClientGroups { get; set; }
        public DbSet<AuditEntityClientGroupClient> AuditEntityClientGroupClients { get; set; }
        public DbSet<AuditEntityCurrency> AuditEntityCurrencies { get; set; }
        public DbSet<AuditEntityExpense> AuditEntityExpenses { get; set; }
        public DbSet<AuditEntityGender> AuditEntityGenders { get; set; }
        public DbSet<AuditEntityJob> AuditEntityJobs { get; set; }
        public DbSet<AuditEntityLocation> AuditEntityLocations { get; set; }
        public DbSet<AuditEntityProject> AuditEntityProjects { get; set; }
        public DbSet<AuditEntityTask> AuditEntityTasks { get; set; }
        public DbSet<AuditEntityTaskCurrencyRate> AuditEntityTaskCurrencyRates { get; set; }
        public DbSet<AuditEntityTimeSheet> AuditEntityTimeSheet { get; set; }
        public DbSet<AuditEntityUser> AuditEntityUsers { get; set; }
        public DbSet<AuditEntityUserDepartment> AuditEntityUserDepartments { get; set; }
        public DbSet<AuditEntityUserDepartmentClaim> AuditEntityUserDepartmentClaims { get; set; }
        public DbSet<AuditEntityUserGroup> AuditEntityUserGroups { get; set; }
        public DbSet<AuditEntityUserGroupUser> AuditEntityUserGroupUsers { get; set; }
        public DbSet<AuditEntityWorkAssignment> AuditEntityWorkAssignments { get; set; }
    }
}
