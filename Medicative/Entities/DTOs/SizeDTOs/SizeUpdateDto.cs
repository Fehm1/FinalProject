namespace Entities.DTOs.SizeDTOs
{
    public class SizeUpdateDto
    {
        public SizeGetDto SizeGet { get; set; }
        public SizePostDto SizePost { get; set; }

        public SizeUpdateDto()
        {
            SizePost = new SizePostDto();
        }
    }
}
