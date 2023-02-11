using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Data;

namespace DataAccessLayer.Concrete.EntityFramework.Configurations
{
    public class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne<Profession>(x => x.Profession).WithMany(x => x.Doctors).HasForeignKey(x => x.ProfessionId);
            builder.HasOne<Department>(x => x.Department).WithMany(x => x.Doctors).HasForeignKey(x => x.DepartmentId);
            builder.Property(x => x.FullName).IsRequired().HasMaxLength(150).HasColumnType(SqlDbType.NVarChar.ToString());
            builder.Property(x => x.Phone).IsRequired().HasMaxLength(50).HasColumnType(SqlDbType.NVarChar.ToString());
            builder.Property(x => x.Email).IsRequired().HasMaxLength(150).HasColumnType(SqlDbType.NVarChar.ToString());
            builder.Property(x => x.ImageURL).IsRequired().HasMaxLength(100).HasColumnType(SqlDbType.NVarChar.ToString());
            builder.Property(x => x.InstagramURL).IsRequired().HasMaxLength(150).HasColumnType(SqlDbType.NVarChar.ToString());
            builder.Property(x => x.TwitterURL).IsRequired().HasMaxLength(150).HasColumnType(SqlDbType.NVarChar.ToString());
            builder.Property(x => x.FacebookURL).IsRequired().HasMaxLength(150).HasColumnType(SqlDbType.NVarChar.ToString());
            builder.Property(x => x.LinekedInURL).IsRequired().HasMaxLength(150).HasColumnType(SqlDbType.NVarChar.ToString());
            builder.Property(x => x.RedirectURL).IsRequired().HasMaxLength(150).HasColumnType(SqlDbType.NVarChar.ToString());
            builder.Property(x => x.CreatedTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.ModifiedTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
            builder.Property(x => x.IsActive).HasDefaultValue(false);
            builder.ToTable("Doctors");
        }
    }
}
