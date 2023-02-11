namespace Entities.DTOs.CertificationDTOs
{
    public class CertificationUpdateDto
    {
        public CertificationGetDto CertificationGet { get; set; }
        public CertificationPostDto CertificationPost { get; set; }

        public CertificationUpdateDto()
        {
            CertificationPost = new CertificationPostDto();
        }
    }
}
