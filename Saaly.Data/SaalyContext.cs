using Microsoft.AspNetCore.DataProtection.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Saaly.Data.Configurations;
using Saaly.Models;
using Saaly.Models.Interfaces;

namespace Saaly.Data
{
    public partial class SaalyContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>, IDataProtectionKeyContext
    {
        public SaalyContext(DbContextOptions<SaalyContext> options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EntityConfiguration());
            modelBuilder.ApplyConfiguration(new EntityTaskConfiguration());
            modelBuilder.ApplyConfiguration(new EntityProjectConfiguration());

            base.OnModelCreating(modelBuilder);
            //  Load all from the current assembly IEntityTypeConfiguration
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);

            //  Add prefix uniformly 
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                entity.SetTableName($"tbl{entity.GetTableName()}");
            }
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<decimal>()
                .HavePrecision(18, 6);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseLoggerFactory(GetLoggerFactory())
                //optionsBuilder.UseSqlServer(ConnectionManager.Connection["ConnectionString"]);
            }
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            HandleUpdatedAtColumns();
            return await base.SaveChangesAsync(cancellationToken);
        }

        public override int SaveChanges()
        {
            HandleUpdatedAtColumns();
            return base.SaveChanges();
        }

        private void HandleUpdatedAtColumns()
        {
            ChangeTracker.DetectChanges();

            var modified = ChangeTracker.Entries()
                .Where(x =>
                x.State == EntityState.Added || x.State == EntityState.Modified || x.State == EntityState.Deleted);

            foreach (var item in modified)
                if (item.Entity is IAuditable entity)
                    item.CurrentValues[nameof(IAuditable.Modified)] = DateTime.UtcNow;
        }
    }
}
