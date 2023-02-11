using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Data;

namespace DataAccessLayer.Concrete.EntityFramework.Configurations
{
    public class SkillConfiguration : IEntityTypeConfiguration<Skill>
    {
        public void Configure(EntityTypeBuilder<Skill> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne<Doctor>(x => x.Doctor).WithMany(x => x.Skills).HasForeignKey(x => x.DoctorId);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(150).HasColumnName(SqlDbType.NVarChar.ToString());
            builder.Property(x => x.Percent).IsRequired().HasMaxLength(150).HasColumnName(SqlDbType.Int.ToString());
            builder.Property(x => x.CreatedTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.ModifiedTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
            builder.Property(x => x.IsActive).HasDefaultValue(false);
            builder.ToTable("Skills");
        }
    }
}
