using Core.Utilities.Abstract;
using Entities.DTOs.EducationDTOs;

namespace Business.Abstract
{
    public interface IEducationService
    {
        Task<IDataResult<EducationGetDto>> GetAsync(int id);
        Task<IDataResult<EducationListDto>> GetAllAsync();
        Task<IDataResult<EducationListDto>> GetAllByNonDeleteAsync(int id);
        Task<IDataResult<EducationUpdateDto>> GetUpdateDto(int id);
        Task<IDataResult<EducationGetDto>> AddAsync(EducationPostDto educationPost);
        Task<IDataResult<EducationGetDto>> Update(EducationUpdateDto educationUpdate);
        Task<IResult> Delete(int id);
        Task<IResult> HardDelete(int id);
    }
}
