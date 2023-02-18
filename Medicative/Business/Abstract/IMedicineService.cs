using Core.Utilities.Abstract;
using Entities.DTOs.MedicineDTOs;

namespace Business.Abstract
{
    public interface IMedicineService
    {
        Task<IDataResult<MedicineGetDto>> GetAsync(int id);
        Task<IDataResult<MedicineListDto>> GetAllAsync();
        Task<IDataResult<MedicineListDto>> GetAllByNonDeleteAsync(int id);
        Task<IDataResult<MedicineUpdateDto>> GetUpdateDto(int id);
        Task<IDataResult<MedicineGetDto>> AddAsync(MedicinePostDto medicinePost);
        Task<IDataResult<MedicineGetDto>> Update(MedicineUpdateDto medicineUpdate);
        Task<IResult> Delete(int id);
        Task<IResult> HardDelete(int id);
    }
}
