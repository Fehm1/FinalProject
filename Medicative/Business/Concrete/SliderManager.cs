using Business.Abstract;
using Core.Utilities.Abstract;
using Entities.DTOs.SliderDTOs;

namespace Business.Concrete
{
    public class SliderManager : ISliderService
    {
        public Task<IDataResult<SliderGetDto>> AddAsync(SliderUpdateDto sliderUpdate)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SliderListDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SliderListDto>> GetAllByNonDeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SliderGetDto>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SliderUpdateDto>> GetUpdateDto(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> HardDelete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SliderGetDto>> Update(SliderUpdateDto sliderUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
