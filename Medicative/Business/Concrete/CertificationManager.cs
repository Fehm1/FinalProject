using AutoMapper;
using Business.Abstract;
using Core.Utilities.Abstract;
using Core.Utilities.Complex_types;
using Core.Utilities.Concrete;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using Entities.DTOs.CertificationDTOs;

namespace Business.Concrete
{
    public class CertificationManager : ICertificationService
    {
        private readonly IUnityOfWork _unityOfWork;
        private readonly IMapper _mapper;

        public CertificationManager(IUnityOfWork unityOfWork, IMapper mapper)
        {
            _unityOfWork = unityOfWork;
            _mapper = mapper;
        }

        public async Task<IDataResult<CertificationGetDto>> AddAsync(CertificationPostDto certificationPost)
        {
            if (certificationPost != null)
            {
                Certification certification = _mapper.Map<Certification>(certificationPost);
                await _unityOfWork.Certification.CreateAsync(certification);
                await _unityOfWork.SaveAsync();

                CertificationGetDto certificationGet = _mapper.Map<CertificationGetDto>(certification);

                return new DataResult<CertificationGetDto>(ResultStatus.Success, certificationGet);
            }

            return new DataResult<CertificationGetDto>(ResultStatus.Error, null, "There are some problem, please check again!");
        }

        public async Task<IResult> Delete(int id)
        {
            Certification certification = await _unityOfWork.Certification.GetAsync(x => x.Id == id);

            if (certification != null)
            {
                certification.IsDeleted = true;
                _unityOfWork.Certification.Update(certification);
                await _unityOfWork.SaveAsync();

                return new Result(ResultStatus.Success);
            }

            return new Result(ResultStatus.Error, "There is no certification in this id!");
        }

        public async Task<IDataResult<CertificationListDto>> GetAllAsync()
        {
            List<Certification> certifications = await _unityOfWork.Certification.GetAllAsync();

            List<CertificationGetDto> certificationGetList = _mapper.Map<List<CertificationGetDto>>(certifications);

            return new DataResult<CertificationListDto>(ResultStatus.Success, new CertificationListDto { Certifications = certificationGetList });
        }

        public async Task<IDataResult<CertificationListDto>> GetAllByNonDeleteAsync(int id)
        {
            List<Certification> certifications = await _unityOfWork.Certification.GetAllAsync(x => x.IsDeleted == false);

            List<CertificationGetDto> certificationGetList = _mapper.Map<List<CertificationGetDto>>(certifications);

            return new DataResult<CertificationListDto>(ResultStatus.Success, new CertificationListDto { Certifications = certificationGetList });
        }

        public async Task<IDataResult<CertificationGetDto>> GetAsync(int id)
        {
            Certification certification = await _unityOfWork.Certification.GetAsync(x => x.Id == id);

            if (certification != null)
            {
                CertificationGetDto certificationGet = _mapper.Map<CertificationGetDto>(certification);

                return new DataResult<CertificationGetDto>(ResultStatus.Success, certificationGet);
            }

            return new DataResult<CertificationGetDto>(ResultStatus.Error, null, "There is no certification in this id!");
        }

        public async Task<IDataResult<CertificationUpdateDto>> GetUpdateDto(int id)
        {
            Certification certification = await _unityOfWork.Certification.GetAsync(x => x.Id == id);
            if(certification is not null)
            {
                CertificationUpdateDto certificationUpdate = new CertificationUpdateDto()
                {
                    CertificationGet = _mapper.Map<CertificationGetDto>(certification)
                };
                return new DataResult<CertificationUpdateDto>(ResultStatus.Success, certificationUpdate);
            }
            return new DataResult<CertificationUpdateDto>(ResultStatus.Error, null, "There is no certificatin with this id");
        }

        public async Task<IResult> HardDelete(int id)
        {
            Certification certification = await _unityOfWork.Certification.GetAsync(x => x.Id == id && x.IsDeleted);

            if (certification != null)
            {
                _unityOfWork.Certification.Delete(certification);
                await _unityOfWork.SaveAsync();

                return new Result(ResultStatus.Success);
            }

            return new Result(ResultStatus.Error, "There is no certification in this id!");
        }

        public async Task<IDataResult<CertificationGetDto>> Update(CertificationUpdateDto certificationUpdate)
        {
            Certification certification = await _unityOfWork.Certification.GetAsync(x => x.Id == certificationUpdate.CertificationGet.Id);
            if(certification is not null)
            {
                certification = _mapper.Map<Certification>(certificationUpdate.CertificationPost);
                certificationUpdate.CertificationGet = _mapper.Map<CertificationGetDto>(certification);

                await _unityOfWork.SaveAsync();
                return new DataResult<CertificationGetDto>(ResultStatus.Success, certificationUpdate.CertificationGet);
            }
            return new DataResult<CertificationGetDto>(ResultStatus.Error, null, "There id no certification in this id");
        }
    }
}
