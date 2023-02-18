using Core.Utilities.Abstract;
using Entities.DTOs.ServiceDTOs;

namespace Business.Abstract
{
    public interface IServiceService
    {
        Task<IDataResult<ServiceGetDto>> GetAsync(int id);
        Task<IDataResult<ServiceListDto>> GetAllAsync();
        Task<IDataResult<ServiceListDto>> GetAllByNonDeleteAsync(int id);
        Task<IDataResult<ServiceUpdateDto>> GetUpdateDto(int id);
        Task<IDataResult<ServiceGetDto>> AddAsync(ServiceUpdateDto serviceUpdate);
        Task<IDataResult<ServiceGetDto>> Update(ServiceUpdateDto serviceUpdate);
        Task<IResult> Delete(int id);
        Task<IResult> HardDelete(int id);
    }
}
