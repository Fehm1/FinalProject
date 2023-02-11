using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework.Context;
using DataAccessLayer.Concrete.EntityFramework.Repositories;

namespace DataAccessLayer.Concrete
{
    public class UnityOfWork : IUnityOfWork
    {
        private readonly AppDbContext _context;
        private EFCertificationRepository _efCertificationRepository;
        private EFCounterRepository _efCounterRepository;
        private EFDepartmentRepository _efDepartmentRepository;
        private EFDepartmentImageRepository _efDepartmentImageRepository;
        private EFDoctorRepository _efDoctorRepository;
        private EFEducationRepository _efEducationRepository;
        private EFMedicineRepository _efMedicineRepository;
        private EFMedicineCategoryRepository _efMedicineCategoryRepository;
        private EFMedicineSizeRepository _efMedicineSizeRepository;
        private EFProfessionRepository _efProfessionRepository;
        private EFServiceRepository _efServiceRepository;
        private EFSkillRepository _efSkillRepository;
        private EFSliderRepository _efSliderRepository;
        private EFSpecializationRepository _efSpecializationRepository;
        private EFTrainingRepository _eftrainingRepository;

        public UnityOfWork(AppDbContext context)
        {
            _context = context;
        }
        public ICertificationRepository Certification => _efCertificationRepository ?? new EFCertificationRepository(_context);

        public ICounterRepository Counter => _efCounterRepository ?? new EFCounterRepository(_context);

        public IDepartmentRepository Department => _efDepartmentRepository ?? new EFDepartmentRepository(_context);

        public IDepartmentImageRepository DepartmentImage => _efDepartmentImageRepository ?? new EFDepartmentImageRepository(_context);

        public IDoctorRepository Doctor => _efDoctorRepository ?? new EFDoctorRepository(_context);

        public IEducationRepostory Education => _efEducationRepository ?? new EFEducationRepository(_context);

        public IMedicineRepository Medicine => _efMedicineRepository ?? new EFMedicineRepository(_context);

        public IMedicineCategoryRepository MedicineCategory => _efMedicineCategoryRepository ?? new EFMedicineCategoryRepository(_context);

        public IMedicineSizeRepository MedicineSize => _efMedicineSizeRepository ?? new EFMedicineSizeRepository(_context);

        public IProfessionRepository Profession => _efProfessionRepository ?? new EFProfessionRepository(_context);

        public IServiceRepository Service => _efServiceRepository ?? new EFServiceRepository(_context);

        public ISkillRepository Skill => _efSkillRepository ?? new EFSkillRepository(_context);

        public ISliderRepository Slider => _efSliderRepository ?? new EFSliderRepository(_context);

        public ISpecializationRepository Specialization => _efSpecializationRepository ?? new EFSpecializationRepository(_context);

        public ITrainingRepository Training => _eftrainingRepository ?? new EFTrainingRepository(_context);

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
