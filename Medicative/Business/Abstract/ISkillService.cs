using Core.Utilities.Abstract;
using Entities.DTOs.SkillDTOs;

namespace Business.Abstract
{
    public interface ISkillService
    {
        Task<IDataResult<SkillGetDto>> GetAsync(int id);
        Task<IDataResult<SkillListDto>> GetAllAsync();
        Task<IDataResult<SkillListDto>> GetAllByNonDeleteAsync(int id);
        Task<IDataResult<SkillUpdateDto>> GetUpdateDto(int id);
        Task<IDataResult<SkillGetDto>> AddAsync(SkillUpdateDto skillUpdate);
        Task<IDataResult<SkillGetDto>> Update(SkillUpdateDto skillUpdate);
        Task<IResult> Delete(int id);
        Task<IResult> HardDelete(int id);
    }
}
