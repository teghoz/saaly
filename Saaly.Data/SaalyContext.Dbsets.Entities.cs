using Microsoft.EntityFrameworkCore;
using Saaly.Models.EntityModels;

namespace Saaly.Data
{
    public partial class SaalyContext
    {
        public DbSet<Entity> Entities { get; set; }
        public DbSet<EntityClient> EntityClients { get; set; }
        public DbSet<EntityCurrency> EntityCurrencies { get; set; }
        public DbSet<EntityExpense> EntityExpenses { get; set; }
        public DbSet<EntityGender> EntityGenders { get; set; }
        public DbSet<EntityJob> EntityJobs { get; set; }
        public DbSet<EntityTask> EntityTasks { get; set; }
        public DbSet<EntityTaskCurrencyRate> EntityTaskCurrencyRates { get; set; }
        public DbSet<EntityProject> EntityProjects { get; set; }
        public DbSet<EntityLocation> EntityLocations { get; set; }
        public DbSet<EntityUser> EntityUsers { get; set; }
        public DbSet<EntityUserDepartment> EntityUserDepartments { get; set; }
        public DbSet<EntityUserDepartmentClaim> EntityUserDepartmentClaims { get; set; }
        public DbSet<EntityUserGroup> EntityUserGroups { get; set; }
        public DbSet<EntityUserGroupUser> EntityUserGroupUsers { get; set; }
        public DbSet<EntityClientBillingInfo> EntityClientBillingInfos { get; set; }
        public DbSet<EntityClientGroup> EntityClientGroups { get; set; }
        public DbSet<EntityClientGroupClient> EntityClientGroupClients { get; set; }
        public DbSet<EntityBillUnit> EntityBillUnits { get; set; }
        public DbSet<EntityBillCode> EntityBillCodes { get; set; }
        public DbSet<EntityBillCodeCurrencyRate> EntityBillCodeCurrencyRates { get; set; }
        public DbSet<EntityTimeSheet> EntityTimeSheets { get; set; }
        public DbSet<EntityWorkAssignment> EntityWorkAssignments { get; set; }
    }
}
