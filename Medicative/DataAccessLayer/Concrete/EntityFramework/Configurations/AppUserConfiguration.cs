using Core.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.Concrete.EntityFramework.Configurations
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.Property(x => x.Address).HasMaxLength(150);
            builder.Property(x => x.Country).HasMaxLength(100);
            builder.Property(x => x.City).HasMaxLength(100);
            builder.Property(x => x.FullName).HasMaxLength(100);
            builder.Property(x => x.UserName).HasMaxLength(100);
            builder.Property(x => x.PhoneNumber).HasMaxLength(50);
            builder.Property(x => x.Email).HasMaxLength(150);
            builder.Property(x => x.ZipCode).HasMaxLength(50);
            builder.Property(x => x.IsAdmin).HasDefaultValue(false);
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
        }
    }
}
