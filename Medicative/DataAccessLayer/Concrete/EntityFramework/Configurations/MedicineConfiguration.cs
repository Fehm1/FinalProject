using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Data;

namespace DataAccessLayer.Concrete.EntityFramework.Configurations
{
    public class MedicineConfiguration : IEntityTypeConfiguration<Medicine>
    {
        public void Configure(EntityTypeBuilder<Medicine> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne<MedicineCategory>(x => x.MedicineCategory).WithMany(x => x.Medicines).HasForeignKey(x => x.CategoryId);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(200).HasColumnType(SqlDbType.NVarChar.ToString());
            builder.Property(x => x.Description).IsRequired().HasMaxLength(750).HasColumnType(SqlDbType.NVarChar.ToString());
            builder.Property(x => x.ImageURL).IsRequired().HasMaxLength(100).HasColumnType(SqlDbType.NVarChar.ToString());
            builder.Property(x => x.Price).IsRequired().HasColumnType(SqlDbType.Float.ToString());
            builder.Property(x => x.BestProduct).HasDefaultValue(false);
            builder.Property(x => x.BestSeller).HasDefaultValue(false);
            builder.Property(x => x.CreatedTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.ModifiedTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
            builder.Property(x => x.IsActive).HasDefaultValue(false);
            builder.ToTable("Medicines");
        }
    }
}
