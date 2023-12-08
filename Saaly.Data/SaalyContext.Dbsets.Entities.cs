using Microsoft.EntityFrameworkCore;
using Saaly.Models.Audits;
using Saaly.Models.EntityModels;

namespace Saaly.Data
{
    public partial class SaalyContext
    {
        public DbSet<Entity> Entities { get; set; }
        public DbSet<AuditEntityClient> EntityClients { get; set; }
        public DbSet<AuditEntityCurrency> EntityCurrencies { get; set; }
        public DbSet<AuditEntityExpense> EntityExpenses { get; set; }
        public DbSet<AuditEntityGender> EntityGenders { get; set; }
        public DbSet<AuditEntityJob> EntityJobs { get; set; }
        public DbSet<EntityTask> EntityTasks { get; set; }
        public DbSet<AuditEntityTaskCurrencyRate> EntityTaskCurrencyRates { get; set; }
        public DbSet<AuditEntityProject> EntityProjects { get; set; }
        public DbSet<AuditEntityLocation> EntityLocations { get; set; }
        public DbSet<AuditEntityUser> EntityUsers { get; set; }
        public DbSet<EntityUserDepartment> EntityUserDepartments { get; set; }
        public DbSet<AuditEntityUserDepartmentClaim> EntityUserDepartmentClaims { get; set; }
        public DbSet<AuditEntityUserGroup> EntityUserGroups { get; set; }
        public DbSet<AuditEntityUserGroupUser> EntityUserGroupUsers { get; set; }
        public DbSet<AuditEntityClientBillingInfo> EntityClientBillingInfos { get; set; }
        public DbSet<AuditEntityClientGroup> EntityClientGroups { get; set; }
        public DbSet<AuditEntityClientGroupClient> EntityClientGroupClients { get; set; }
        public DbSet<AuditEntityBillUnit> EntityBillUnits { get; set; }
        public DbSet<AuditEntityBillCode> EntityBillCodes { get; set; }
        public DbSet<AuditEntityBillCodeCurrencyRate> EntityBillCodeCurrencyRates { get; set; }
        public DbSet<AuditEntityTimeSheet> EntityTimeSheets { get; set; }
        public DbSet<EntityWorkAssignment> EntityWorkAssignments { get; set; }
    }
}
