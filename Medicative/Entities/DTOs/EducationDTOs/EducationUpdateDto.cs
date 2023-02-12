namespace Entities.DTOs.EducationDTOs
{
    public class EducationUpdateDto
    {
        public EducationGetDto EducationGet { get; set; }
        public EducationPostDto EducationPost { get; set; }

        public EducationUpdateDto()
        {
            EducationPost = new EducationPostDto();
        }
    }
}
