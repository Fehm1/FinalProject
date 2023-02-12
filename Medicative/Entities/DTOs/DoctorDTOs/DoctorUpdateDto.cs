namespace Entities.DTOs.DoctorDTOs
{
    public class DoctorUpdateDto
    {
        public DoctorGetDto DoctorGet { get; set; }
        public DoctorPostDto DoctorPost { get; set; }

        public DoctorUpdateDto()
        {
            DoctorPost = new DoctorPostDto();
        }
    }
}
