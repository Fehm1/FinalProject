using Core.Utilities.Abstract;
using Entities.DTOs.DoctorDTOs;

namespace Business.Abstract
{
    public interface IDoctorService
    {
        Task<IDataResult<DoctorGetDto>> GetAsync(int id);
        Task<IDataResult<DoctorListDto>> GetAllAsync();
        Task<IDataResult<DoctorListDto>> GetAllByNonDeleteAsync();
        Task<IDataResult<DoctorListDto>> GetAllByDeletedAsync();
        Task<IDataResult<DoctorUpdateDto>> GetUpdateDto(int id);
        Task<IDataResult<DoctorGetDto>> AddAsync(DoctorPostDto doctorPost);
        Task<IDataResult<DoctorGetDto>> Update(DoctorUpdateDto doctorUpdate);
        Task<IResult> Delete(int id);
        Task<IResult> Restore(int id);
        Task<IResult> HardDelete(int id);
    }
}
