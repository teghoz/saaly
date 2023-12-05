using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Saaly.Models.EntityModels;

namespace Saaly.Data.Configurations
{
    public class EntityConfiguration : IEntityTypeConfiguration<Entity>
    {
        public void Configure(EntityTypeBuilder<Entity> builder)
        {
            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd()
                .Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);

            //builder.Property(p => p.Slug).HasMaxLength(100);
            //builder.Property(p => p.DefaultUserName).HasMaxLength(50);
            //builder.Property(p => p.DefaultPassword).HasMaxLength(50);
            //builder.HasIndex(e => e.Slug).IsUnique();
            //builder.HasIndex(e => e.DefaultUserName).IsUnique();
        }
    }
}
