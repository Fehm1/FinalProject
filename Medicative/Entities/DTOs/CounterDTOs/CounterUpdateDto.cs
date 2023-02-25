namespace Entities.DTOs.CounterDTOs
{
    public class CounterUpdateDto
    {
        public CounterGetDto CounterGet { get; set; } = new CounterGetDto();
        public CounterPostDto CounterPost { get; set; } = new CounterPostDto();

        public CounterUpdateDto()
        {
            CounterPost = new CounterPostDto();
        }
    }
}
