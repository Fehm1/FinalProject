using AutoMapper;
using Business.Abstract;
using Core.Utilities.Abstract;
using Core.Utilities.Complex_types;
using Core.Utilities.Concrete;
using Core.Utilities.Extensions.FileManagerExtentions;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using Entities.DTOs.DoctorDTOs;
using Microsoft.AspNetCore.Hosting;

namespace Business.Concrete
{
    public class DoctorManager : IDoctorService
    {
        private readonly IUnityOfWork _unityOfWork;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _env;

        public DoctorManager(IUnityOfWork unityOfWork, IMapper mapper, IWebHostEnvironment env)
        {
            _unityOfWork = unityOfWork;
            _mapper = mapper;
            _env = env;
        }

        public async Task<IDataResult<DoctorGetDto>> AddAsync(DoctorPostDto doctorPost)
        {

            if (doctorPost != null)
            {
                Doctor doctor = _mapper.Map<Doctor>(doctorPost);

                if (doctorPost.formFile != null)
                {
                    if (!doctorPost.formFile.IsImageContent())
                    {
                        return new DataResult<DoctorGetDto>(ResultStatus.Error, null, "These fields are required!!!");
                    }

                    if (!doctorPost.formFile.IsValidImageLength())
                    {
                        return new DataResult<DoctorGetDto>(ResultStatus.Error, null, "These fields are required!!!");
                    }

                    doctor.ImageURL = doctorPost.formFile.SaveImage(_env.WebRootPath, "uploads/doctors");
                }
                else
                {
                    return new DataResult<DoctorGetDto>(ResultStatus.Error, null, "Image required!");
                }

                if (doctorPost.SpecializationPosts != null)
                {
                    foreach (var item in doctorPost.SpecializationPosts)
                    {
                        Specialization specialization = _mapper.Map<Specialization>(item);
                        specialization.Doctor = doctor;
                        doctor.Specializations.Add(specialization);
                    }
                }

                if (doctorPost.CertificationPosts != null)
                {
                    foreach (var item in doctorPost.CertificationPosts)
                    {
                        Certification certification = _mapper.Map<Certification>(item);
                        certification.Doctor = doctor;
                        doctor.Certifications.Add(certification);
                    }
                }

                if (doctorPost.EducationPosts != null)
                {
                    foreach (var item in doctorPost.EducationPosts)
                    {
                        Education education = _mapper.Map<Education>(item);
                        education.Doctor = doctor;
                        doctor.Educations.Add(education);
                    }
                }

                if (doctorPost.TrainingPosts != null)
                {
                    foreach (var item in doctorPost.TrainingPosts)
                    {
                        Training training = _mapper.Map<Training>(item);
                        training.Doctor = doctor;
                        doctor.Training.Add(training);
                    }
                }

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
            List<Doctor> doctors = await _unityOfWork.Doctor.GetAllAsync(null, x => x.Department, x => x.Profession);
            DoctorListDto doctorListDto = new DoctorListDto()
            {
                DoctorList = _mapper.Map<List<DoctorGetDto>>(doctors)
            };

            return new DataResult<DoctorListDto>(ResultStatus.Success, doctorListDto);
        }

        public async Task<IDataResult<DoctorListDto>> GetAllByDeletedAsync()
        {
            List<Doctor> doctors = await _unityOfWork.Doctor.GetAllAsync(x => x.IsDeleted == true, x => x.Department, x => x.Profession);
            DoctorListDto doctorListDto = new DoctorListDto()
            {
                DoctorList = _mapper.Map<List<DoctorGetDto>>(doctors)
            };

            return new DataResult<DoctorListDto>(ResultStatus.Success, doctorListDto);
        }

        public async Task<IDataResult<DoctorListDto>> GetAllByNonDeleteAsync()
        {
            List<Doctor> doctors = await _unityOfWork.Doctor.GetAllAsync(x=>!x.IsDeleted, x => x.Department, x => x.Profession);
            DoctorListDto doctorListDto = new DoctorListDto()
            {
                DoctorList = _mapper.Map<List<DoctorGetDto>>(doctors)
            };

            return new DataResult<DoctorListDto>(ResultStatus.Success, doctorListDto);
        }

        public async  Task<IDataResult<DoctorGetDto>> GetAsync(int id)
        {
            Doctor doctor  = await _unityOfWork.Doctor.GetAsync(x=>x.Id == id, x => x.Department, x => x.Profession);

            if (doctor != null)
            {
                DoctorGetDto doctorGet = _mapper.Map<DoctorGetDto >(doctor);

                return new DataResult<DoctorGetDto >(ResultStatus.Success, doctorGet);
            }

            return new DataResult<DoctorGetDto >(ResultStatus.Error, null, "There is no doctor in this id!");
        }

        public async Task<IDataResult<DoctorUpdateDto>> GetUpdateDto(int id)
        {
            Doctor doctor  = await _unityOfWork.Doctor.GetAsync(x=>x.Id == id, x => x.Department, x => x.Profession,
                x => x.Certifications, x => x.Training, x => x.Specializations, x => x.Educations);
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
            Doctor doctor  = await _unityOfWork.Doctor.GetAsync(x => x.Id == id && x.IsDeleted, x => x.Department, x => x.Profession);

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
            Doctor doctor  = await _unityOfWork.Doctor.GetAsync(x => x.Id == doctorUpdate.DoctorGet.Id, x => x.Department, x => x.Profession,
                x => x.Specializations, x => x.Training, x => x.Certifications, x => x.Educations);

            if (doctorUpdate is not null)
            {
                if (doctorUpdate.DoctorPost.formFile != null)
                {
                    if (!doctorUpdate.DoctorPost.formFile.IsImageContent())
                    {
                        return new DataResult<DoctorGetDto>(ResultStatus.Error, null, "These fields are required!!!");
                    }

                    if (!doctorUpdate.DoctorPost.formFile.IsValidImageLength())
                    {
                        return new DataResult<DoctorGetDto>(ResultStatus.Error, null, "These fields are required!!!");
                    }

                    string image = doctorUpdate.DoctorPost.formFile.SaveImage(_env.WebRootPath, "uploads/doctors");
                    doctor.ImageURL.DeleteImage(_env.WebRootPath, "uploads/doctors");

                    doctor.ImageURL = image;
                }

                if (doctorUpdate.DoctorPost.TrainingPosts != null)
                {
                    doctorUpdate.DoctorPost.TrainingPosts.RemoveAll(x => x.DoctorId == doctor.Id);
                    foreach (var item in doctorUpdate.DoctorPost.TrainingPosts)
                    {
                        Training training = _mapper.Map<Training>(item);
                        training.DoctorId = doctor.Id;
                        doctor.Training.Add(training);
                    }
                }

                if (doctorUpdate.DoctorPost.CertificationPosts != null)
                {
                    doctorUpdate.DoctorPost.CertificationPosts.RemoveAll(x => x.DoctorId == doctor.Id);
                    foreach (var item in doctorUpdate.DoctorPost.CertificationPosts)
                    {
                        Certification certification = _mapper.Map<Certification>(item);
                        certification.DoctorId = doctor.Id;
                        doctor.Certifications.Add(certification);
                    }
                }

                if (doctorUpdate.DoctorPost.SpecializationPosts != null)
                {
                    doctorUpdate.DoctorPost.SpecializationPosts.RemoveAll(x => x.DoctorId == doctor.Id);
                    foreach (var item in doctorUpdate.DoctorPost.SpecializationPosts)
                    {
                        Specialization specialization = _mapper.Map<Specialization>(item);
                        specialization.DoctorId = doctor.Id;
                        doctor.Specializations.Add(specialization);
                    }
                }

                if (doctorUpdate.DoctorPost.EducationPosts != null)
                {
                    doctorUpdate.DoctorPost.EducationPosts.RemoveAll(x => x.DoctorId == doctor.Id);
                    foreach (var item in doctorUpdate.DoctorPost.EducationPosts)
                    {
                        Education education = _mapper.Map<Education>(item);
                        education.DoctorId = doctor.Id;
                        doctor.Educations.Add(education);
                    }
                }

                doctor.FullName = doctorUpdate.DoctorPost.FullName;
                doctor.InstagramURL = doctorUpdate.DoctorPost.InstagramURL;
                doctor.FacebookURL = doctorUpdate.DoctorPost.FacebookURL;
                doctor.TwitterURL = doctorUpdate.DoctorPost.TwitterURL;
                doctor.LinekedInURL = doctorUpdate.DoctorPost.LinekedInURL;
                doctor.ProfessionId = doctorUpdate.DoctorPost.ProfessionId;
                doctor.DepartmentId = doctorUpdate.DoctorPost.DepartmentId;
                doctor.Email = doctorUpdate.DoctorPost.Email;
                doctor.Phone = doctorUpdate.DoctorPost.Phone;

                doctorUpdate.DoctorGet = _mapper.Map<DoctorGetDto>(doctor);

                _unityOfWork.Doctor.Update(doctor);
                await _unityOfWork.SaveAsync();
                return new DataResult<DoctorGetDto >(ResultStatus.Success, doctorUpdate.DoctorGet);
            }
            return new DataResult<DoctorGetDto >(ResultStatus.Error, null, "There id no doctor in this id");
        }

       
    }
}
