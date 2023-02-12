using AutoMapper;
using Entities.Concrete;
using Entities.DTOs.CertificationDTOs;

namespace Business.AutoMapper
{
    public class EntityProfile : Profile
    {
        public EntityProfile()
        {
            CreateMap<Certification, CertificationGetDto>();
            CreateMap<CertificationPostDto, Certification>();
        }
    }
}
