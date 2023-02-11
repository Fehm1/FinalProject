using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Data;

namespace DataAccessLayer.Concrete.EntityFramework.Configurations
{
    public class DepartmentImageConfiguration : IEntityTypeConfiguration<DepartmentImage>
    {
        public void Configure(EntityTypeBuilder<DepartmentImage> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne<Department>(x => x.Department).WithMany(x => x.Images).HasForeignKey(x => x.DeparmentId);
            builder.Property(x => x.ImageURL).IsRequired().HasMaxLength(100).HasColumnType(SqlDbType.NVarChar.ToString());
            builder.Property(x => x.IsPoster).IsRequired().HasDefaultValue(false);
            builder.Property(x => x.CreatedTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.ModifiedTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
            builder.Property(x => x.IsActive).HasDefaultValue(false);
            builder.ToTable("DepartmentImages");
        }
    }
}
