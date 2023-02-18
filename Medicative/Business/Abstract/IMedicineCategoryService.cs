using Core.Utilities.Abstract;
using Entities.DTOs.MedicineCategoryDTOs;

namespace Business.Abstract
{
    public interface IMedicineCategoryService
    {
        Task<IDataResult<MedicineCategoryGetDto>> GetAsync(int id);
        Task<IDataResult<MedicineCategoryListDto>> GetAllAsync();
        Task<IDataResult<MedicineCategoryListDto>> GetAllByNonDeleteAsync(int id);
        Task<IDataResult<MedicineCategoryUpdateDto>> GetUpdateDto(int id);
        Task<IDataResult<MedicineCategoryGetDto>> AddAsync(MedicineCategoryPostDto medicineCategoryPost);
        Task<IDataResult<MedicineCategoryGetDto>> Update(MedicineCategoryUpdateDto medicineCategoryUpdate);
        Task<IResult> Delete(int id);
        Task<IResult> HardDelete(int id);
    }
}
