namespace Entities.DTOs.ServiceDTOs
{
    public class ServiceUpdateDto
    {
        public ServiceGetDto ServiceGet { get; set; }
        public ServicePostDto ServicePost { get; set; }

        public ServiceUpdateDto()
        {
            ServicePost = new ServicePostDto();
        }
    }
}
