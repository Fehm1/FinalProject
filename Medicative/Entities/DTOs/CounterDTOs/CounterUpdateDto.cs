namespace Entities.DTOs.CounterDTOs
{
    public class CounterUpdateDto
    {
        public CounterGetDto CounterGet { get; set; }
        public CounterPostDto CounterPost { get; set; }

        public CounterUpdateDto()
        {
            CounterPost = new CounterPostDto();
        }
    }
}
