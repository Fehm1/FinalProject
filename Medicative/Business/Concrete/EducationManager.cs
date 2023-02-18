using AutoMapper;
using Business.Abstract;
using Core.Utilities.Abstract;
using Core.Utilities.Complex_types;
using Core.Utilities.Concrete;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using Entities.DTOs.CertificationDTOs;
using Entities.DTOs.DoctorDTOs;
using Entities.DTOs.EducationDTOs;

namespace Business.Concrete
{
    public class EducationManager : IEducationService
    {
        private readonly IUnityOfWork _unityOfWork;
        private readonly IMapper _mapper;

        public EducationManager(IUnityOfWork unityOfWork, IMapper mapper)
        {
            _unityOfWork = unityOfWork;
            _mapper = mapper;
        }
        public async Task<IDataResult<EducationGetDto>> AddAsync(EducationPostDto educationPost)
        {
            if (educationPost != null)
            {
                Education education = _mapper.Map<Education>(educationPost);
                await _unityOfWork.Education.CreateAsync(education);
                await _unityOfWork.SaveAsync();

                EducationGetDto educationGet = _mapper.Map<EducationGetDto>(education);

                return new DataResult<EducationGetDto>(ResultStatus.Success, educationGet);
            }

            return new DataResult<EducationGetDto>(ResultStatus.Error, null, "There are some problem, please check again!");
        }

        public async Task<IResult> Delete(int id)
        {
            Education education = await _unityOfWork.Education.GetAsync(x => x.Id == id);

            if (education != null)
            {
                education.IsDeleted = true;
                _unityOfWork.Education.Update(education);
                await _unityOfWork.SaveAsync();

                return new Result(ResultStatus.Success);
            }

            return new Result(ResultStatus.Error, "There is no education in this id!");
        }

        public async Task<IDataResult<EducationListDto>> GetAllAsync()
        {
            List<Education> educations = await _unityOfWork.Education.GetAllAsync();
            EducationListDto educationList = new EducationListDto()
            {
                EducationList = _mapper.Map<List<EducationGetDto>>(educations)
            };

            return new DataResult<EducationListDto>(ResultStatus.Success, educationList);
        }

        public async Task<IDataResult<EducationListDto>> GetAllByNonDeleteAsync(int id)
        {
            List<Education> educations = await _unityOfWork.Education.GetAllAsync(x => !x.IsDeleted);
            EducationListDto educationList = new EducationListDto()
            {
                EducationList = _mapper.Map<List<EducationGetDto>>(educations)
            };

            return new DataResult<EducationListDto>(ResultStatus.Success, educationList);
        }

        public async Task<IDataResult<EducationGetDto>> GetAsync(int id)
        {
            Education education = await _unityOfWork.Education.GetAsync(x => x.Id == id);

            if (education != null)
            {
                EducationGetDto educationGet = _mapper.Map<EducationGetDto>(education);

                return new DataResult<EducationGetDto>(ResultStatus.Success, educationGet);
            }

            return new DataResult<EducationGetDto>(ResultStatus.Error, null, "There is no education in this id!");
        }

        public async Task<IDataResult<EducationUpdateDto>> GetUpdateDto(int id)
        {
            Education education = await _unityOfWork.Education.GetAsync(x => x.Id == id);
            if (education is not null)
            {
                EducationUpdateDto educationUpdate = new EducationUpdateDto()
                {
                    EducationGet = _mapper.Map<EducationGetDto>(education)
                };
                return new DataResult<EducationUpdateDto>(ResultStatus.Success, educationUpdate);
            }
            return new DataResult<EducationUpdateDto>(ResultStatus.Error, null, "There is no education with this id");
        }

        public async Task<IResult> HardDelete(int id)
        {
            Education education = await _unityOfWork.Education.GetAsync(x => x.Id == id && x.IsDeleted);

            if (education != null)
            {
                _unityOfWork.Education.Delete(education);
                await _unityOfWork.SaveAsync();

                return new Result(ResultStatus.Success);
            }

            return new Result(ResultStatus.Error, "There is no education in this id!");
        }

        public async Task<IDataResult<EducationGetDto>> Update(EducationUpdateDto educationUpdate)
        {
            Education education = await _unityOfWork.Education.GetAsync(x => x.Id == educationUpdate.EducationGet.Id);
            if (educationUpdate is not null)
            {
                education = _mapper.Map<Education>(educationUpdate.EducationPost);
                educationUpdate.EducationGet = _mapper.Map<EducationGetDto>(education);

                await _unityOfWork.SaveAsync();
                return new DataResult<EducationGetDto>(ResultStatus.Success, educationUpdate.EducationGet);
            }
            return new DataResult<EducationGetDto>(ResultStatus.Error, null, "There id no education in this id");
        }
    }
}
