using Core.Utilities.Abstract;
using Entities.DTOs.SizeDTOs;

namespace Business.Abstract
{
    public interface ISizeService
    {
        Task<IDataResult<SizeGetDto>> GetAsync(int id);
        Task<IDataResult<SizeListDto>> GetAllAsync();
        Task<IDataResult<SizeListDto>> GetAllByNonDeleteAsync(int id);
        Task<IDataResult<SizeUpdateDto>> GetUpdateDto(int id);
        Task<IDataResult<SizeGetDto>> AddAsync(SizeUpdateDto sizeUpdate);
        Task<IDataResult<SizeGetDto>> Update(SizeUpdateDto sizeUpdate);
        Task<IResult> Delete(int id);
        Task<IResult> HardDelete(int id);
    }
}
