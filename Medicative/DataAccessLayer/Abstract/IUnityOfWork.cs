namespace DataAccessLayer.Abstract
{
    public interface IUnityOfWork
    {
        ICertificationRepository Certification { get; }
        ICounterRepository Counter { get; }
        IDepartmentRepository Department { get; }
        IDoctorRepository Doctor { get; }
        IEducationRepostory Education { get; }
        IMedicineRepository Medicine { get; }
        IMedicineCategoryRepository MedicineCategory { get; }
        IMedicineSizeRepository MedicineSize { get; }
        IProfessionRepository Profession { get; }
        IServiceRepository Service { get; }
        ISkillRepository Skill { get; }
        ISliderRepository Slider { get; }
        ISpecializationRepository Specialization{ get; }
        ITrainingRepository Training { get; }

        Task<int> SaveAsync();

    }
}
