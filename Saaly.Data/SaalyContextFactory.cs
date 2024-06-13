using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Saaly.Data
{
    public class SaalyContextFactory : IDesignTimeDbContextFactory<SaalyContext>
    {
        public SaalyContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SaalyContext>();
            optionsBuilder.UseNpgsql("Host=localhost,5432;Database=Saaly;Username=postgres;Password=T@gh0z2017;Include Error Detail=true");

            return new SaalyContext(optionsBuilder.Options);
        }
    }
}
