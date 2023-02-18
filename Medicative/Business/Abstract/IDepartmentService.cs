using Core.Utilities.Abstract;
using Entities.DTOs.DepartmentDTOs;

namespace Business.Abstract
{
    public interface IDepartmentService
    {
        Task<IDataResult<DepartmentGetDto>> GetAsync(int id);
        Task<IDataResult<DepartmentListDto>> GetAllAsync();
        Task<IDataResult<DepartmentListDto>> GetAllByNonDeleteAsync(int id);
        Task<IDataResult<DepartmentUpdateDto>> GetUpdateDto(int id);
        Task<IDataResult<DepartmentGetDto>> Update(DepartmentUpdateDto departmentUpdate);
        Task<IResult> Delete(int id);
    }
}
