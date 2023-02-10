using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Data;

namespace DataAccessLayer.Concrete.EntityFramework.Configurations
{
    public class MedicineCategoryConfiguration : IEntityTypeConfiguration<MedicineCategory>
    {
        public void Configure(EntityTypeBuilder<MedicineCategory> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Category).IsRequired().HasMaxLength(200).HasColumnType(SqlDbType.NVarChar.ToString());
            builder.Property(x => x.CreatedTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.ModifiedTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
            builder.Property(x => x.IsActive).HasDefaultValue(false);
        }
    }
}
