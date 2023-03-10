using Core.Utilities.Abstract;
using Entities.DTOs.DepartmentDTOs;

namespace Business.Abstract
{
    public interface IDepartmentService
    {
        Task<IDataResult<DepartmentGetDto>> GetAsync(int id);
        Task<IDataResult<DepartmentListDto>> GetAllAsync();
        Task<IDataResult<DepartmentListDto>> GetAllByNonDeleteAsync();
        Task<IDataResult<DepartmentUpdateDto>> GetUpdateDto(int id);
        Task<IDataResult<DepartmentGetDto>> Update(DepartmentUpdateDto departmentUpdate);
    }
}
