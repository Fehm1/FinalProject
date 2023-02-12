namespace Entities.DTOs.SpecializationDTOs
{
    public class SpecializationUpdateDto
    {
        public SpecializationGetDto SpecializationGet { get; set; }
        public SpecializationPostDto SpecializationPost { get; set; }

        public SpecializationUpdateDto()
        {
            SpecializationPost = new SpecializationPostDto();
        }
    }
}
