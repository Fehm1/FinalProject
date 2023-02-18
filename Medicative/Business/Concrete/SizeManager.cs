using Business.Abstract;
using Core.Utilities.Abstract;
using Entities.DTOs.SizeDTOs;

namespace Business.Concrete
{
    public class SizeManager : ISizeService
    {
        public Task<IDataResult<SizeGetDto>> AddAsync(SizeUpdateDto sizeUpdate)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SizeListDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SizeListDto>> GetAllByNonDeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SizeGetDto>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SizeUpdateDto>> GetUpdateDto(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> HardDelete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SizeGetDto>> Update(SizeUpdateDto sizeUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
