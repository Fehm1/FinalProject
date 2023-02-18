using Business.Abstract;
using Core.Utilities.Abstract;
using Entities.DTOs.ServiceDTOs;

namespace Business.Concrete
{
    public class ServiceManager : IServiceService
    {
        public Task<IDataResult<ServiceGetDto>> AddAsync(ServiceUpdateDto serviceUpdate)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<ServiceListDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<ServiceListDto>> GetAllByNonDeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<ServiceGetDto>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<ServiceUpdateDto>> GetUpdateDto(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> HardDelete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<ServiceGetDto>> Update(ServiceUpdateDto serviceUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
