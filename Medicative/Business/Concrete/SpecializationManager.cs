using Business.Abstract;
using Core.Utilities.Abstract;
using Entities.DTOs.SpecializationDTOs;

namespace Business.Concrete
{
    public class SpecializationManager : ISpecializationService
    {
        public Task<IDataResult<SpecializationGetDto>> AddAsync(SpecializationUpdateDto specializationUpdate)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SpecializationListDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SpecializationListDto>> GetAllByNonDeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SpecializationGetDto>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SpecializationUpdateDto>> GetUpdateDto(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> HardDelete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SpecializationGetDto>> Update(SpecializationUpdateDto specializationUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
