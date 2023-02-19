using AutoMapper;
using Business.Abstract;
using Core.Utilities.Abstract;
using Core.Utilities.Complex_types;
using Core.Utilities.Concrete;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using Entities.DTOs.ProfessionDTOs;

namespace Business.Concrete
{
    public class ProfessionManager : IProfessionService
    {
        private readonly IUnityOfWork _unityOfWork;
        private readonly IMapper _mapper;

        public ProfessionManager(IUnityOfWork unityOfWork, IMapper mapper)
        {
            _unityOfWork = unityOfWork;
            _mapper = mapper;
        }

        public async Task<IDataResult<ProfessionGetDto>> AddAsync(ProfessionPostDto professionPost)
        {
            if (professionPost != null)
            {
                Profession profession = _mapper.Map<Profession>(professionPost);
                await _unityOfWork.Profession.CreateAsync(profession);
                await _unityOfWork.SaveAsync();

                ProfessionGetDto professionGet = _mapper.Map<ProfessionGetDto>(profession);

                return new DataResult<ProfessionGetDto>(ResultStatus.Success, professionGet);
            }

            return new DataResult<ProfessionGetDto>(ResultStatus.Error, null, "There are some problem, please check again!");
        }

        public async Task<IResult> Delete(int id)
        {
            Profession profession = await _unityOfWork.Profession.GetAsync(x => x.Id == id);

            if (profession != null)
            {
                profession.IsDeleted = true;
                _unityOfWork.Profession.Update(profession);
                await _unityOfWork.SaveAsync();

                return new Result(ResultStatus.Success);
            }

            return new Result(ResultStatus.Error, "There is no profession in this id!");
        }

        public async Task<IDataResult<ProfessionListDto>> GetAllAsync()
        {
            List<Profession> professions = await _unityOfWork.Profession.GetAllAsync();

            List<ProfessionGetDto> professionGetList = _mapper.Map<List<ProfessionGetDto>>(professions);

            return new DataResult<ProfessionListDto>(ResultStatus.Success, new ProfessionListDto { Professions = professionGetList });
        }

        public async Task<IDataResult<ProfessionListDto>> GetAllByDeletedAsync()
        {
            List<Profession> professions = await _unityOfWork.Profession.GetAllAsync(x => x.IsDeleted == true);

            List<ProfessionGetDto> professionGetList = _mapper.Map<List<ProfessionGetDto>>(professions);

            return new DataResult<ProfessionListDto>(ResultStatus.Success, new ProfessionListDto { Professions = professionGetList });
        }

        public async Task<IDataResult<ProfessionListDto>> GetAllByNonDeleteAsync()
        {
            List<Profession> professions = await _unityOfWork.Profession.GetAllAsync(x => x.IsDeleted == false);

            List<ProfessionGetDto> professionGetList = _mapper.Map<List<ProfessionGetDto>>(professions);

            return new DataResult<ProfessionListDto>(ResultStatus.Success, new ProfessionListDto { Professions = professionGetList });
        }

        public async Task<IDataResult<ProfessionGetDto>> GetAsync(int id)
        {
            Profession profession = await _unityOfWork.Profession.GetAsync(x => x.Id == id);

            if (profession != null)
            {
                ProfessionGetDto professionGet = _mapper.Map<ProfessionGetDto>(profession);

                return new DataResult<ProfessionGetDto>(ResultStatus.Success, professionGet);
            }

            return new DataResult<ProfessionGetDto>(ResultStatus.Error, null, "There is no profession in this id!");
        }

        public async Task<IDataResult<ProfessionUpdateDto>> GetUpdateDto(int id)
        {
            Profession profession = await _unityOfWork.Profession.GetAsync(x => x.Id == id);
            if (profession is not null)
            {
                ProfessionUpdateDto professionUpdate = new ProfessionUpdateDto()
                {
                    ProfessionGet = _mapper.Map<ProfessionGetDto>(profession)
                };
                return new DataResult<ProfessionUpdateDto>(ResultStatus.Success, professionUpdate);
            }
            return new DataResult<ProfessionUpdateDto>(ResultStatus.Error, null, "There is no profession with this id");
        }

        public async Task<IResult> HardDelete(int id)
        {
            Profession profession = await _unityOfWork.Profession.GetAsync(x => x.Id == id && x.IsDeleted);

            if (profession != null )
            {
                _unityOfWork.Profession.Delete(profession);
                await _unityOfWork.SaveAsync();

                return new Result(ResultStatus.Success);
            }

            return new Result(ResultStatus.Error, "There is no profession in this id!");
        }

        public async Task<IResult> Restore(int id)
        {
            Profession profession = await _unityOfWork.Profession.GetAsync(x => x.Id == id);

            if (profession != null)
            {
                profession.IsDeleted = false;
                _unityOfWork.Profession.Update(profession);
                await _unityOfWork.SaveAsync();

                return new Result(ResultStatus.Success);
            }

            return new Result(ResultStatus.Error, "There is no profession in this id!");
        }

        public async Task<IDataResult<ProfessionGetDto>> Update(ProfessionUpdateDto professionUpdate)
        {
            Profession profession = await _unityOfWork.Profession.GetAsync(x => x.Id == professionUpdate.ProfessionGet.Id);
            if (professionUpdate is not null)
            {
                profession.ModifiedTime = DateTime.Now;
                profession = _mapper.Map<Profession>(professionUpdate.ProfessionPost);
                professionUpdate.ProfessionGet = _mapper.Map<ProfessionGetDto>(profession);

                await _unityOfWork.SaveAsync();
                return new DataResult<ProfessionGetDto>(ResultStatus.Success, professionUpdate.ProfessionGet);
            }
            return new DataResult<ProfessionGetDto>(ResultStatus.Error, null, "There id no profession with this id");
        }
    }
}
