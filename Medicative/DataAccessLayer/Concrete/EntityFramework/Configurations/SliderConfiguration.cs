using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Data;

namespace DataAccessLayer.Concrete.EntityFramework.Configurations
{
    public class SliderConfiguration : IEntityTypeConfiguration<Slider>
    {
        public void Configure(EntityTypeBuilder<Slider> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.TitleWhite).IsRequired().HasMaxLength(100).HasColumnType(SqlDbType.NVarChar.ToString());
            builder.Property(x => x.TitleGreen).IsRequired().HasMaxLength(100).HasColumnType(SqlDbType.NVarChar.ToString());
            builder.Property(x => x.Description).IsRequired().HasMaxLength(150).HasColumnType(SqlDbType.NVarChar.ToString());
            builder.Property(x => x.ImageUrl).IsRequired().HasMaxLength(100).HasColumnType(SqlDbType.NVarChar.ToString());
            builder.Property(x => x.RedirectURL).IsRequired().HasMaxLength(150).HasColumnType(SqlDbType.NVarChar.ToString());
            builder.Property(x => x.CreatedTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.ModifiedTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
            builder.Property(x => x.IsActive).HasDefaultValue(false);
            builder.ToTable("Sliders");
        }
    }
}
