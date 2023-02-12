using Core.Utilities.Abstract;
using Entities.DTOs.CertificationDTOs;

namespace Business.Abstract
{
    public interface ICertificationService
    {
        Task<IDataResult<CertificationGetDto>> GetAsync(int id);
        Task<IDataResult<CertificationListDto>> GetAllAsync();
        Task<IDataResult<CertificationListDto>> GetAllByNonDeleteAsync(int id);
        Task<IDataResult<CertificationGetDto>> AddAsync(CertificationPostDto certificationPost);
        Task<IDataResult<CertificationGetDto>> Update(CertificationUpdateDto certificationUpdate);
        Task<IResult> Delete(int id);
        Task<IResult> HardDelete(int id);

    }
}
