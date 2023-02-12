namespace Entities.DTOs.MedicineCategoryDTOs
{
    public class MedicineCategoryUpdateDto
    {
        public MedicineCategoryGetDto MedicineCategoryGet { get; set; }
        public MedicineCategoryPostDto MedicineCategoryPost { get; set; }

        public MedicineCategoryUpdateDto()
        {
            MedicineCategoryPost = new MedicineCategoryPostDto();
        }
    }
}
