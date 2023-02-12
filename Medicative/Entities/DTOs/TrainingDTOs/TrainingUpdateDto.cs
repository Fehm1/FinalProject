namespace Entities.DTOs.TrainingDTOs
{
    public class TrainingUpdateDto
    {
        public TrainingGetDto TrainingGet { get; set; }
        public TrainingPostDto TrainingPost { get; set; }

        public TrainingUpdateDto()
        {
            TrainingPost = new TrainingPostDto();
        }
    }
}
