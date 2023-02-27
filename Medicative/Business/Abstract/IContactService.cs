using Core.Utilities.Abstract;
using Entities.DTOs.ContactDTOs;

namespace Business.Abstract
{
    public interface IContactService
    {
        Task<IDataResult<ContactGetDto>> GetAsync(int id);
        Task<IDataResult<ContactListDto>> GetAllAsync();
        Task<IDataResult<ContactListDto>> GetAllByNonDeleteAsync();
        Task<IDataResult<ContactListDto>> GetAllDeletedAsync();
        Task<IDataResult<ContactGetDto>> AddAsync(ContactPostDto contactPost);
        Task<IResult> Restore(int id);
        Task<IResult> Status(int id);
        Task<IResult> Delete(int id);
        Task<IResult> HardDelete(int id);
    }
}
