using Business.Abstract;
using Business.Concrete;
using Business.Services.Abstract;
using Business.Services.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework.Context;
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

            serviceCollection.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("default"));
            });
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
            serviceCollection.AddScoped<ISettingService,  SettingManager>();

            serviceCollection.AddScoped<LayoutService>();


            return serviceCollection;
        }
    }
}
