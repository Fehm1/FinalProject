using Core.Entity.Concrete;
using Entities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete.EntityFramework.Context
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Certification> Certifications { get; set; }
        public DbSet<Counter> Counters { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<DepartmentImage> DepartmentImages { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Profession> Professions { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Specialization> Specializations { get; set; }
        public DbSet<Training> Trainings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: "Server=LAPTOP-8KCHFK1I\\SQLEXPRESS;Database=MedicativeDB;Trusted_Connection=True");
        }
    }
}
