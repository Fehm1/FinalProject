using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Data;

namespace DataAccessLayer.Concrete.EntityFramework.Configurations
{
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.FullName).IsRequired().HasMaxLength(100).HasColumnType(SqlDbType.NVarChar.ToString());
            builder.Property(x => x.Email).IsRequired().HasMaxLength(100).HasColumnType(SqlDbType.NVarChar.ToString());
            builder.Property(x => x.Subject).IsRequired().HasMaxLength(100).HasColumnType(SqlDbType.NVarChar.ToString());
            builder.Property(x => x.Message).IsRequired().HasMaxLength(500).HasColumnType(SqlDbType.NVarChar.ToString());
            builder.Property(x => x.CreatedTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.ModifiedTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
            builder.Property(x => x.IsActive).HasDefaultValue(true);
        }
    }
}
