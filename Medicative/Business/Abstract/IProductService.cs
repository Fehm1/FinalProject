using Core.Utilities.Abstract;
using Entities.DTOs.CategoryDTOs;
using Entities.DTOs.ProductDTOs;

namespace Business.Abstract
{
    public interface IProductService
    {
        Task<IDataResult<ProductGetDto>> GetAsync(int id);
        Task<IDataResult<ProductListDto>> GetAllAsync();
        Task<IDataResult<ProductListDto>> GetAllByNonDeleteAsync();
        Task<IDataResult<ProductListDto>> GetAllDeletedAsync();
        Task<IDataResult<ProductUpdateDto>> GetUpdateDto(int id);
        Task<IDataResult<ProductGetDto>> AddAsync(ProductPostDto productPost);
        Task<IDataResult<ProductGetDto>> Update(ProductUpdateDto productUpdate);
        Task<IResult> Restore(int id);
        Task<IResult> Delete(int id);
        Task<IResult> HardDelete(int id);
    }
}
