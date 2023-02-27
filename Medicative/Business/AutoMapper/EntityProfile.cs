using AutoMapper;
using Entities.Concrete;
using Entities.DTOs.CertificationDTOs;
using Entities.DTOs.ContactDTOs;
using Entities.DTOs.CounterDTOs;
using Entities.DTOs.DepartmentDTOs;
using Entities.DTOs.DoctorDTOs;
using Entities.DTOs.EducationDTOs;
using Entities.DTOs.ProfessionDTOs;
using Entities.DTOs.ServiceDTOs;
using Entities.DTOs.SettingDTOs;
using Entities.DTOs.SliderDTOs;
using Entities.DTOs.SpecializationDTOs;
using Entities.DTOs.TrainingDTOs;

namespace Business.AutoMapper
{
    public class EntityProfile : Profile
    {
        public EntityProfile()
        {
            CreateMap<Certification, CertificationGetDto>();
            CreateMap<CertificationPostDto, Certification>();

            CreateMap<Counter, CounterGetDto>();
            CreateMap<CounterPostDto, Counter>();

            CreateMap<Department, DepartmentGetDto>();
            CreateMap<DepartmentPostDto, Department>();

            CreateMap<Doctor, DoctorGetDto>();
            CreateMap<DoctorPostDto, Doctor>();

            CreateMap<Education, EducationGetDto>();
            CreateMap<EducationPostDto, Education>();

            CreateMap<Profession, ProfessionGetDto>();
            CreateMap<ProfessionPostDto, Profession>();

            CreateMap<Service, ServiceGetDto>();
            CreateMap<ServicePostDto, Service>();

            CreateMap<Slider, SliderGetDto>();
            CreateMap<SliderPostDto, Slider>();

            CreateMap<Specialization, SpecializationGetDto>();
            CreateMap<SpecializationPostDto, Specialization>();

            CreateMap<Training, TrainingGetDto>();
            CreateMap<TrainingPostDto, Training>();

            CreateMap<Contact, ContactGetDto>();
            CreateMap<ContactPostDto, Contact>();

            CreateMap<Setting, SettingGetDto>();
            CreateMap<SettingPostDto, Setting>();
        }
    }
}
