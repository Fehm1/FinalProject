using Core.Utilities.Abstract;
using Entities.DTOs.CategoryDTOs;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        Task<IDataResult<CategoryGetDto>> GetAsync(int id);
        Task<IDataResult<CategoryListDto>> GetAllAsync();
        Task<IDataResult<CategoryListDto>> GetAllByNonDeleteAsync();
        Task<IDataResult<CategoryListDto>> GetAllDeletedAsync();
        Task<IDataResult<CategoryUpdateDto>> GetUpdateDto(int id);
        Task<IDataResult<CategoryGetDto>> AddAsync(CategoryPostDto categoryPost);
        Task<IDataResult<CategoryGetDto>> Update(CategoryUpdateDto categoryUpdate);
        Task<IResult> Restore(int id);
        Task<IResult> Delete(int id);
        Task<IResult> HardDelete(int id);
    }
}
