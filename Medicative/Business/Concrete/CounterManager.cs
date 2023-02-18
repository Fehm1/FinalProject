using AutoMapper;
using Business.Abstract;
using Core.Utilities.Abstract;
using Core.Utilities.Complex_types;
using Core.Utilities.Concrete;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using Entities.DTOs.CertificationDTOs;
using Entities.DTOs.CounterDTOs;
using System.Runtime.CompilerServices;

namespace Business.Concrete
{
    public class CounterManager : ICounterService
    {
        private readonly IUnityOfWork _unityOfWork;
        private readonly IMapper _mapper;

        public CounterManager(IUnityOfWork unityOfWork, IMapper mapper)
        {
            _unityOfWork = unityOfWork;
            _mapper = mapper;
        }

        public async Task<IDataResult<CounterGetDto>> AddAsync(CounterPostDto counterPost)
        {
            if (counterPost != null)
            {
                Counter counter = _mapper.Map<Counter>(counterPost);
                await _unityOfWork.Counter.CreateAsync(counter);
                await _unityOfWork.SaveAsync();

                CounterGetDto counterGet = _mapper.Map<CounterGetDto>(counter);

                return new DataResult<CounterGetDto>(ResultStatus.Success, counterGet);
            }

            return new DataResult<CounterGetDto>(ResultStatus.Error, null, "There are some problem, please check again!");
        }

        public async Task<IResult> Delete(int id)
        {
            Counter counter = await _unityOfWork.Counter.GetAsync(x => x.Id == id);

            if (counter != null)
            {
                counter.IsDeleted = true;
                _unityOfWork.Counter.Update(counter);
                await _unityOfWork.SaveAsync();

                return new Result(ResultStatus.Success);
            }

            return new Result(ResultStatus.Error, "There is no counter in this id!");
        }

        public async Task<IDataResult<CounterListDto>> GetAllAsync()
        {
            List<Counter> counters = await _unityOfWork.Counter.GetAllAsync();

            List<CounterGetDto> counterGets = _mapper.Map<List<CounterGetDto>>(counters);

            return new DataResult<CounterListDto>(ResultStatus.Success, new CounterListDto { Counters = counterGets });
        }

        public async Task<IDataResult<CounterListDto>> GetAllByNonDeleteAsync(int id)
        {
            List<Counter> counters = await _unityOfWork.Counter.GetAllAsync(x => x.IsDeleted == false);

            List<CounterGetDto> counterGets = _mapper.Map<List<CounterGetDto>>(counters);

            return new DataResult<CounterListDto>(ResultStatus.Success, new CounterListDto { Counters = counterGets });
        }

        public async Task<IDataResult<CounterGetDto>> GetAsync(int id)
        {
            Counter counter = await _unityOfWork.Counter.GetAsync(x => x.Id == id);

            if (counter != null)
            {
                CounterGetDto counterGet = _mapper.Map<CounterGetDto>(counter);

                return new DataResult<CounterGetDto>(ResultStatus.Success, counterGet);
            }

            return new DataResult<CounterGetDto>(ResultStatus.Error, null, "There is no counter in this id!");
        }

        public async Task<IDataResult<CounterUpdateDto>> GetUpdateDto(int id)
        {
            Counter counter = await _unityOfWork.Counter.GetAsync(x => x.Id == id);
            if (counter is not null)
            {
                CounterUpdateDto counterUpdate = new CounterUpdateDto()
                {
                    CounterGet = _mapper.Map<CounterGetDto>(counter)
                };
                return new DataResult<CounterUpdateDto>(ResultStatus.Success, counterUpdate);
            }
            return new DataResult<CounterUpdateDto>(ResultStatus.Error, null, "There is no counter with this id");
        }

        public async Task<IResult> HardDelete(int id)
        {
            Counter counter = await _unityOfWork.Counter.GetAsync(x => x.Id == id && x.IsDeleted);

            if (counter != null)
            {
                _unityOfWork.Counter.Delete(counter);
                await _unityOfWork.SaveAsync();

                return new Result(ResultStatus.Success);
            }

            return new Result(ResultStatus.Error, "There is no counter in this id!");
        }

        public async Task<IDataResult<CounterGetDto>> Update(CounterUpdateDto counterUpdate)
        {
            Counter counter = await _unityOfWork.Counter.GetAsync(x => x.Id == counterUpdate.CounterGet.Id);
            if (counter is not null)
            {
                counter = _mapper.Map<Counter>(counterUpdate.CounterPost);
                counterUpdate.CounterGet = _mapper.Map<CounterGetDto>(counter);

                await _unityOfWork.SaveAsync();
                return new DataResult<CounterGetDto>(ResultStatus.Success, counterUpdate.CounterGet);
            }
            return new DataResult<CounterGetDto>(ResultStatus.Error, null, "There id no counter in this id");
        }
    }
}
