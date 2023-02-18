using AutoMapper;
using Business.Abstract;
using Core.Utilities.Abstract;
using Core.Utilities.Complex_types;
using Core.Utilities.Concrete;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using Entities.DTOs.DoctorDTOs;

namespace Business.Concrete
{
    public class DoctorManager : IDoctorService
    {
        private readonly IUnityOfWork _unityOfWork;
        private readonly IMapper _mapper;

        public DoctorManager(IUnityOfWork unityOfWork, IMapper mapper)
        {
            _unityOfWork = unityOfWork;
            _mapper = mapper;
        }

        public async Task<IDataResult<DoctorGetDto>> AddAsync(DoctorPostDto doctorPost)
        {
            if (doctorPost != null)
            {
                Doctor doctor = _mapper.Map<Doctor>(doctorPost);
                await _unityOfWork.Doctor.CreateAsync(doctor);
                await _unityOfWork.SaveAsync();

                DoctorGetDto doctorGetDto = _mapper.Map<DoctorGetDto>(doctor);

                return new DataResult<DoctorGetDto>(ResultStatus.Success, doctorGetDto);
            }

            return new DataResult<DoctorGetDto>(ResultStatus.Error, null, "These fields are required!!!");
        }

        public async Task<IResult> Delete(int id)
        {
            Doctor doctor = await _unityOfWork.Doctor.GetAsync(x => x.Id == id);

            if (doctor != null)
            {
                doctor.IsDeleted = true;
                _unityOfWork.Doctor.Update(doctor);
                await _unityOfWork.SaveAsync();

                return new Result(ResultStatus.Success);
            }

            return new Result(ResultStatus.Error, "There is no department in this id!");
        }

        public async Task<IDataResult<DoctorListDto>> GetAllAsync()
        {
            List<Doctor> doctors = await _unityOfWork.Doctor.GetAllAsync();
            DoctorListDto doctorListDto = new DoctorListDto()
            {
                DoctorList = _mapper.Map<List<DoctorGetDto>>(doctors)
            };

            return new DataResult<DoctorListDto>(ResultStatus.Success, doctorListDto);
        }

        public async Task<IDataResult<DoctorListDto>> GetAllByNonDeleteAsync(int id)
        {
            List<Doctor> doctors = await _unityOfWork.Doctor.GetAllAsync(x=>!x.IsDeleted);
            DoctorListDto doctorListDto = new DoctorListDto()
            {
                DoctorList = _mapper.Map<List<DoctorGetDto>>(doctors)
            };

            return new DataResult<DoctorListDto>(ResultStatus.Success, doctorListDto);
        }

        public async  Task<IDataResult<DoctorGetDto>> GetAsync(int id)
        {
            Doctor doctor  = await _unityOfWork.Doctor.GetAsync(x=>x.Id == id);

            if (doctor != null)
            {
                DoctorGetDto doctorGet = _mapper.Map<DoctorGetDto >(doctor);

                return new DataResult<DoctorGetDto >(ResultStatus.Success, doctorGet);
            }

            return new DataResult<DoctorGetDto >(ResultStatus.Error, null, "There is no doctor in this id!");
        }

        public async Task<IDataResult<DoctorUpdateDto>> GetUpdateDto(int id)
        {
            Doctor doctor  = await _unityOfWork.Doctor.GetAsync(x=>x.Id == id);
            if (doctor is not null)
            {
                DoctorUpdateDto doctorUpdate = new DoctorUpdateDto()
                {
                    DoctorGet = _mapper.Map<DoctorGetDto >(doctor)
                };
                return new DataResult<DoctorUpdateDto>(ResultStatus.Success, doctorUpdate);
            }
            return new DataResult<DoctorUpdateDto>(ResultStatus.Error, null, "There is no doctor with this id");
        }

        public async Task<IResult> HardDelete(int id)
        {
            Doctor doctor  = await _unityOfWork.Doctor.GetAsync(x => x.Id == id && x.IsDeleted);

            if (doctor != null)
            {
                _unityOfWork.Doctor.Delete(doctor);
                await _unityOfWork.SaveAsync();

                return new Result(ResultStatus.Success);
            }

            return new Result(ResultStatus.Error, "There is no doctor in this id!");
        }

        public async Task<IDataResult<DoctorGetDto>> Update(DoctorUpdateDto doctorUpdate)
        {
            Doctor doctor  = await _unityOfWork.Doctor.GetAsync(x => x.Id == doctorUpdate.DoctorGet.Id);
            if (doctorUpdate is not null)
            {
                doctor = _mapper.Map<Doctor>(doctorUpdate.DoctorPost);
                doctorUpdate.DoctorGet = _mapper.Map<DoctorGetDto>(doctor);

                await _unityOfWork.SaveAsync();
                return new DataResult<DoctorGetDto >(ResultStatus.Success, doctorUpdate.DoctorGet);
            }
            return new DataResult<DoctorGetDto >(ResultStatus.Error, null, "There id no doctor in this id");
        }

       
    }
}
