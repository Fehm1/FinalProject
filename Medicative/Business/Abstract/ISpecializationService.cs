using Core.Utilities.Abstract;
using Entities.DTOs.SpecializationDTOs;

namespace Business.Abstract
{
    public interface ISpecializationService
    {
        Task<IDataResult<SpecializationGetDto>> GetAsync(int id);
        Task<IDataResult<SpecializationListDto>> GetAllAsync();
        Task<IDataResult<SpecializationListDto>> GetAllByNonDeleteAsync(int id);
        Task<IDataResult<SpecializationUpdateDto>> GetUpdateDto(int id);
        Task<IDataResult<SpecializationGetDto>> AddAsync(SpecializationUpdateDto specializationUpdate);
        Task<IDataResult<SpecializationGetDto>> Update(SpecializationUpdateDto specializationUpdate);
        Task<IResult> Delete(int id);
        Task<IResult> HardDelete(int id);
    }
}
