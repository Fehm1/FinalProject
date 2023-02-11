using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Data;

namespace DataAccessLayer.Concrete.EntityFramework.Configurations
{
    public class CounterConfiguration : IEntityTypeConfiguration<Counter>
    {
        public void Configure(EntityTypeBuilder<Counter> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Icon).IsRequired().HasMaxLength(150).HasColumnName(SqlDbType.NVarChar.ToString());
            builder.Property(x => x.Name).IsRequired().HasMaxLength(150).HasColumnName(SqlDbType.NVarChar.ToString());
            builder.Property(x => x.Count).IsRequired().HasMaxLength(150).HasColumnName(SqlDbType.Int.ToString());
            builder.Property(x => x.CreatedTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.ModifiedTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
            builder.Property(x => x.IsActive).HasDefaultValue(false);
            builder.ToTable("Counters");
        }
    }
}
