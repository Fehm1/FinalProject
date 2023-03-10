namespace DataAccessLayer.Abstract
{
    public interface IUnityOfWork
    {
        ICertificationRepository Certification { get; }
        ICounterRepository Counter { get; }
        IDepartmentRepository Department { get; }
        IDoctorRepository Doctor { get; }
        IEducationRepostory Education { get; }
        IProfessionRepository Profession { get; }
        IServiceRepository Service { get; }
        ISliderRepository Slider { get; }
        ISpecializationRepository Specialization{ get; }
        ITrainingRepository Training { get; }
        IContactRepository Contact { get; }
        IProductRepository Product { get; }
        ICategoryRepository Category { get; }
        IOrderRepository Order { get; }
        IOrderItemRepository OrderItem { get; }
        ISettingRepostory Setting { get; }

        Task<int> SaveAsync();

    }
}
