using Core.Utilities.Abstract;
using Entities.DTOs.CounterDTOs;

namespace Business.Abstract
{
    public interface ICounterService
    {
        Task<IDataResult<CounterGetDto>> GetAsync(int id);
        Task<IDataResult<CounterListDto>> GetAllAsync();
        Task<IDataResult<CounterListDto>> GetAllByNonDeleteAsync();
        Task<IDataResult<CounterListDto>> GetAllByDeletedAsync();
        Task<IDataResult<CounterUpdateDto>> GetUpdateDto(int id);
        Task<IDataResult<CounterGetDto>> AddAsync(CounterPostDto counterPost);
        Task<IDataResult<CounterGetDto>> Update(CounterUpdateDto counterUpdate);
        Task<IResult> Delete(int id);
        Task<IResult> Restore(int id);
        Task<IResult> HardDelete(int id);
    }
}
