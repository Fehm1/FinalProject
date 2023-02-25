using AutoMapper;
using Business.Abstract;
using Core.Utilities.Abstract;
using Core.Utilities.Complex_types;
using Core.Utilities.Concrete;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using Entities.DTOs.ProfessionDTOs;
using Entities.DTOs.ServiceDTOs;

namespace Business.Concrete
{
    public class ServiceManager : IServiceService
    {
        private readonly IUnityOfWork _unityOfWork;
        private readonly IMapper _mapper;

        public ServiceManager(IUnityOfWork unityOfWork, IMapper mapper)
        {
            _unityOfWork = unityOfWork;
            _mapper = mapper;
        }

        public async Task<IDataResult<ServiceGetDto>> AddAsync(ServicePostDto servicePost)
        {
            if (servicePost != null)
            {
                Service service = _mapper.Map<Service>(servicePost);
                await _unityOfWork.Service.CreateAsync(service);
                await _unityOfWork.SaveAsync();

                ServiceGetDto serviceGet = _mapper.Map<ServiceGetDto>(service);

                return new DataResult<ServiceGetDto>(ResultStatus.Success, serviceGet);
            }

            return new DataResult<ServiceGetDto>(ResultStatus.Error, null, "There are some problem, please check again!");
        }

        public async Task<IResult> Delete(int id)
        {
            Service service = await _unityOfWork.Service.GetAsync(x => x.Id == id);

            if (service != null)
            {
                service.IsDeleted = true;
                _unityOfWork.Service.Update(service);
                await _unityOfWork.SaveAsync();

                return new Result(ResultStatus.Success);
            }

            return new Result(ResultStatus.Error, "There is no service in this id!");
        }

        public async Task<IDataResult<ServiceListDto>> GetAllAsync()
        {
            List<Service> services = await _unityOfWork.Service.GetAllAsync();

            List<ServiceGetDto> serviceGets = _mapper.Map<List<ServiceGetDto>>(services);

            return new DataResult<ServiceListDto>(ResultStatus.Success, new ServiceListDto { ServiceList = serviceGets });
        }

        public async Task<IDataResult<ServiceListDto>> GetAllByNonDeleteAsync()
        {
            List<Service> services = await _unityOfWork.Service.GetAllAsync(x => x.IsDeleted == false);

            List<ServiceGetDto> serviceGets = _mapper.Map<List<ServiceGetDto>>(services);

            return new DataResult<ServiceListDto>(ResultStatus.Success, new ServiceListDto { ServiceList = serviceGets });
        }

        public async Task<IDataResult<ServiceListDto>> GetAllDeletedAsync()
        {
            List<Service> services = await _unityOfWork.Service.GetAllAsync(x => x.IsDeleted == true);

            List<ServiceGetDto> serviceGets = _mapper.Map<List<ServiceGetDto>>(services);

            return new DataResult<ServiceListDto>(ResultStatus.Success, new ServiceListDto { ServiceList = serviceGets });
        }

        public async Task<IDataResult<ServiceGetDto>> GetAsync(int id)
        {
            Service service = await _unityOfWork.Service.GetAsync(x => x.Id == id);

            if (service != null)
            {
                ServiceGetDto serviceGet = _mapper.Map<ServiceGetDto>(service);

                return new DataResult<ServiceGetDto>(ResultStatus.Success, serviceGet);
            }

            return new DataResult<ServiceGetDto>(ResultStatus.Error, null, "There is no service in this id!");
        }

        public async Task<IDataResult<ServiceUpdateDto>> GetUpdateDto(int id)
        {
            Service service = await _unityOfWork.Service.GetAsync(x => x.Id == id);
            if (service is not null)
            {
                ServiceUpdateDto serviceUpdate = new ServiceUpdateDto()
                {
                    ServiceGet = _mapper.Map<ServiceGetDto>(service)
                };
                return new DataResult<ServiceUpdateDto>(ResultStatus.Success, serviceUpdate);
            }
            return new DataResult<ServiceUpdateDto>(ResultStatus.Error, null, "There is no service with this id");
        }

        public async Task<IResult> HardDelete(int id)
        {
            Service service = await _unityOfWork.Service.GetAsync(x => x.Id == id);

            if (service != null)
            {
                _unityOfWork.Service.Delete(service);
                await _unityOfWork.SaveAsync();

                return new Result(ResultStatus.Success);
            }

            return new Result(ResultStatus.Error, "There is no service in this id!");
        }

        public async Task<IResult> Restore(int id)
        {
            Service service = await _unityOfWork.Service.GetAsync(x => x.Id == id);

            if (service != null)
            {
                service.IsDeleted = false;
                _unityOfWork.Service.Update(service);
                await _unityOfWork.SaveAsync();

                return new Result(ResultStatus.Success);
            }

            return new Result(ResultStatus.Error, "There is no service in this id!");
        }

        public async Task<IDataResult<ServiceGetDto>> Update(ServiceUpdateDto serviceUpdate)
        {
            Service service = await _unityOfWork.Service.GetAsync(x => x.Id == serviceUpdate.ServiceGet.Id);
            if (serviceUpdate is not null)
            {
                service.Icon = serviceUpdate.ServicePost.Icon;
                service.Title = serviceUpdate.ServicePost.Title;
                service.Description = serviceUpdate.ServicePost.Description;
                service.RedirectURL = serviceUpdate.ServicePost.RedirectURL;
                service.ModifiedTime = DateTime.Now;

                _unityOfWork.Service.Update(service);
                await _unityOfWork.SaveAsync();

                serviceUpdate.ServiceGet = _mapper.Map<ServiceGetDto>(service);
                return new DataResult<ServiceGetDto>(ResultStatus.Success, serviceUpdate.ServiceGet);
            }
            return new DataResult<ServiceGetDto>(ResultStatus.Error, null, "There id no service with this id");
        }
    }
}
