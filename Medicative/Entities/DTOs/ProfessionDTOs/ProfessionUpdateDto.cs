namespace Entities.DTOs.ProfessionDTOs
{
    public class ProfessionUpdateDto
    {
        public ProfessionGetDto ProfessionGet { get; set; }
        public ProfessionPostDto ProfessionPost { get; set; }

        public ProfessionUpdateDto()
        {
            ProfessionPost = new ProfessionPostDto();
        }
    }
}
