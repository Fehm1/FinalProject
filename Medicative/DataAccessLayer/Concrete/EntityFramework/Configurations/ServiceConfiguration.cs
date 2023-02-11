using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Data;

namespace DataAccessLayer.Concrete.EntityFramework.Configurations
{
    public class ServiceConfiguration : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Icon).IsRequired().HasMaxLength(150).HasColumnName(SqlDbType.NVarChar.ToString());
            builder.Property(x => x.Title).IsRequired().HasMaxLength(150).HasColumnName(SqlDbType.NVarChar.ToString());
            builder.Property(x => x.Description).IsRequired().HasMaxLength(300).HasColumnName(SqlDbType.NVarChar.ToString());
            builder.Property(x => x.RedirectURL).IsRequired().HasMaxLength(150).HasColumnName(SqlDbType.NVarChar.ToString());
            builder.Property(x => x.CreatedTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.ModifiedTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
            builder.Property(x => x.IsActive).HasDefaultValue(false);
            builder.ToTable("Services");
        }
    }
}
