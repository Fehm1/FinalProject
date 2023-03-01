using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Data;

namespace DataAccessLayer.Concrete.EntityFramework.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne<Category>(x => x.Category).WithMany(x => x.Products).HasForeignKey(x => x.CategoryId);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100).HasColumnType(SqlDbType.NVarChar.ToString());
            builder.Property(x => x.Description).IsRequired().HasMaxLength(400).HasColumnType(SqlDbType.NVarChar.ToString());
            builder.Property(x => x.ImageUrl).IsRequired().HasMaxLength(100).HasColumnType(SqlDbType.NVarChar.ToString());
            builder.Property(x => x.Count).IsRequired().HasColumnType(SqlDbType.Int.ToString());
            builder.Property(x => x.Price).IsRequired().HasColumnType(SqlDbType.Float.ToString());
            builder.Property(x => x.DiscountPercent).IsRequired().HasColumnType(SqlDbType.Int.ToString());
            builder.Property(x => x.IsPopular).HasDefaultValue(false);
            builder.Property(x => x.TopSeller).HasDefaultValue(false);
            builder.Property(x => x.ImageUrl).IsRequired().HasMaxLength(100).HasColumnType(SqlDbType.NVarChar.ToString());
            builder.Property(x => x.CreatedTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.ModifiedTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
            builder.Property(x => x.IsActive).HasDefaultValue(false);
        }
    }
}
