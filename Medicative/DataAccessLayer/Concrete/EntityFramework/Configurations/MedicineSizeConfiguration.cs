using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Data;

namespace DataAccessLayer.Concrete.EntityFramework.Configurations
{
    public class MedicineSizeConfiguration : IEntityTypeConfiguration<MedicineSize>
    {
        public void Configure(EntityTypeBuilder<MedicineSize> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Size).IsRequired().HasMaxLength(200).HasColumnType(SqlDbType.NVarChar.ToString());
            builder.Property(x => x.CreatedTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.ModifiedTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
            builder.Property(x => x.IsActive).HasDefaultValue(false);
            builder.HasOne<Medicine>(x => x.Medicine).WithMany(x => x.MedicineSizes).HasForeignKey(x => x.MedicineId);
            builder.ToTable("MedicineSizes");
        }
    }
}
