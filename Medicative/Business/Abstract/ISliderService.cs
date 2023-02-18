using Core.Utilities.Abstract;
using Entities.DTOs.SliderDTOs;

namespace Business.Abstract
{
    public interface ISliderService
    {
        Task<IDataResult<SliderGetDto>> GetAsync(int id);
        Task<IDataResult<SliderListDto>> GetAllAsync();
        Task<IDataResult<SliderListDto>> GetAllByNonDeleteAsync(int id);
        Task<IDataResult<SliderUpdateDto>> GetUpdateDto(int id);
        Task<IDataResult<SliderGetDto>> AddAsync(SliderUpdateDto sliderUpdate);
        Task<IDataResult<SliderGetDto>> Update(SliderUpdateDto sliderUpdate);
        Task<IResult> Delete(int id);
        Task<IResult> HardDelete(int id);
    }
}
