using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework.Context;
using DataAccessLayer.Concrete.EntityFramework.Repositories;

namespace DataAccessLayer.Concrete
{
    public class UnityOfWork : IUnityOfWork
    {
        private readonly AppDbContext _context;
        private readonly ICertificationRepository _efCertificationRepository;
        private readonly ICounterRepository _efCounterRepository;
        private readonly IDepartmentRepository _efDepartmentRepository;
        private readonly IDoctorRepository _efDoctorRepository;
        private readonly IEducationRepostory _efEducationRepository;
        private readonly IProfessionRepository _efProfessionRepository;
        private readonly IServiceRepository _efServiceRepository;
        private readonly ISliderRepository _efSliderRepository;
        private readonly ISpecializationRepository _efSpecializationRepository;
        private readonly ITrainingRepository _eftrainingRepository;
        private readonly IContactRepository _efContactRepository;
        private readonly ISettingRepostory _efsettingRepository;

        public UnityOfWork(AppDbContext context)
        {
            _context = context;
        }
        public ICertificationRepository Certification => _efCertificationRepository ?? new EFCertificationRepository(_context);

        public ICounterRepository Counter => _efCounterRepository ?? new EFCounterRepository(_context);

        public IDepartmentRepository Department => _efDepartmentRepository ?? new EFDepartmentRepository(_context);

        public IDoctorRepository Doctor => _efDoctorRepository ?? new EFDoctorRepository(_context);

        public IEducationRepostory Education => _efEducationRepository ?? new EFEducationRepository(_context);

        public IProfessionRepository Profession => _efProfessionRepository ?? new EFProfessionRepository(_context);

        public IServiceRepository Service => _efServiceRepository ?? new EFServiceRepository(_context);

        public ISliderRepository Slider => _efSliderRepository ?? new EFSliderRepository(_context);

        public ISpecializationRepository Specialization => _efSpecializationRepository ?? new EFSpecializationRepository(_context);

        public ITrainingRepository Training => _eftrainingRepository ?? new EFTrainingRepository(_context);

        public IContactRepository Contact => _efContactRepository ?? new EFContactRepository(_context);

        public ISettingRepostory Setting => _efsettingRepository ?? new EFSettingRepository(_context);


        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
