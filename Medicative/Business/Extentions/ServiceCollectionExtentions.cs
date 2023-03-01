using Business.Abstract;
using Business.Concrete;
using Business.Services.Abstract;
using Business.Services.Concrete;
using Core.Entity.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Business.Extentions
{
    public static class ServiceCollectionExtentions
    {
        public static IServiceCollection AddBusinessConfiguration(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            //AppDbContext
            serviceCollection.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("default"));
            });

            //Adding managers
            serviceCollection.AddScoped<IUnityOfWork, UnityOfWork>();
            serviceCollection.AddAutoMapper(Assembly.GetExecutingAssembly());
            serviceCollection.AddScoped<ICertificationService,  CertificationManager>();
            serviceCollection.AddScoped<ICounterService,  CounterManager>();
            serviceCollection.AddScoped<IDepartmentService,  DepartmentManager>();
            serviceCollection.AddScoped<IDoctorService,  DoctorManager>();
            serviceCollection.AddScoped<IEducationService,  EducationManager>();
            serviceCollection.AddScoped<IProfessionService,  ProfessionManager>();
            serviceCollection.AddScoped<IServiceService,  ServiceManager>();
            serviceCollection.AddScoped<ISliderService,  SliderManager>();
            serviceCollection.AddScoped<ISpecializationService,  SpecializationManager>();
            serviceCollection.AddScoped<ITrainingService,  TrainingManager>();
            serviceCollection.AddScoped<IContactService,  ContactManager>();
            serviceCollection.AddScoped<ICategoryService,  CategoryManager>();
            serviceCollection.AddScoped<IProductService,  ProductManager>();
            serviceCollection.AddScoped<ISettingService,  SettingManager>();

            //Adding services
            serviceCollection.AddScoped<LayoutService>();
            serviceCollection.AddScoped<ManageLayoutService>();

            //Adding appUser
            serviceCollection.AddIdentity<AppUser, IdentityRole>(opt =>
            {

                opt.Password.RequiredUniqueChars = 0;
                opt.Password.RequiredLength = 8;
                opt.Password.RequireNonAlphanumeric = false;
                opt.Password.RequireDigit = true;
                opt.Password.RequireLowercase = true;
                opt.Password.RequireUppercase = false;

                opt.User.RequireUniqueEmail = false;

            }).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

            return serviceCollection;
        }
    }
}
