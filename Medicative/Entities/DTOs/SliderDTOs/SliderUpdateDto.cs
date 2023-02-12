namespace Entities.DTOs.SliderDTOs
{
    public class SliderUpdateDto
    {
        public SliderGetDto SliderGet { get; set; }
        public SliderPostDto SliderPost { get; set; }

        public SliderUpdateDto()
        {
            SliderPost = new SliderPostDto();
        }
    }
}
