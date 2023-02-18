using Core.Utilities.Abstract;
using Entities.DTOs.DepartmentImageDTOs;

namespace Business.Abstract
{
    public interface IDepartmentImageService
    {
        Task<IDataResult<DepartmentImageGetDto>> GetAsync(int id);
        Task<IDataResult<DepartmentImageListDto>> GetAllAsync();
        Task<IDataResult<DepartmentImageListDto>> GetAllByNonDeleteAsync(int id);
        Task<IDataResult<DepartmentImageUpdateDto>> GetUpdateDto(int id);
        Task<IDataResult<DepartmentImageGetDto>> AddAsync(DepartmentImagePostDto departmentImagePost);
        Task<IDataResult<DepartmentImageGetDto>> Update(DepartmentImageUpdateDto departmentImageUpdate);
        Task<IResult> Delete(int id);
        Task<IResult> HardDelete(int id);
    }
}
