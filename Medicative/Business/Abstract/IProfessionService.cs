using Core.Utilities.Abstract;
using Entities.DTOs.ProfessionDTOs;

namespace Business.Abstract
{
    public interface IProfessionService
    {
        Task<IDataResult<ProfessionGetDto>> GetAsync(int id);
        Task<IDataResult<ProfessionListDto>> GetAllAsync();
        Task<IDataResult<ProfessionListDto>> GetAllByNonDeleteAsync();
        Task<IDataResult<ProfessionListDto>> GetAllByDeletedAsync();
        Task<IDataResult<ProfessionUpdateDto>> GetUpdateDto(int id);
        Task<IDataResult<ProfessionGetDto>> AddAsync(ProfessionPostDto professionPost);
        Task<IDataResult<ProfessionGetDto>> Update(ProfessionUpdateDto professionUpdate);
        Task<IResult> Delete(int id);
        Task<IResult> HardDelete(int id);
        Task<IResult> Restore(int id);
    }
}
