using Core.Utilities.Abstract;
using Entities.DTOs.ServiceDTOs;

namespace Business.Abstract
{
    public interface IServiceService
    {
        Task<IDataResult<ServiceGetDto>> GetAsync(int id);
        Task<IDataResult<ServiceListDto>> GetAllAsync();
        Task<IDataResult<ServiceListDto>> GetAllByNonDeleteAsync();
        Task<IDataResult<ServiceListDto>> GetAllDeletedAsync();
        Task<IDataResult<ServiceUpdateDto>> GetUpdateDto(int id);
        Task<IDataResult<ServiceGetDto>> AddAsync(ServicePostDto servicePost);
        Task<IDataResult<ServiceGetDto>> Update(ServiceUpdateDto serviceUpdate);
        Task<IResult> Delete(int id);
        Task<IResult> Restore(int id);
        Task<IResult> HardDelete(int id);
    }
}
