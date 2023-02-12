namespace Entities.DTOs.MedicineDTOs
{
    public class MedicineUpdateDto
    {
        public MedicineGetDto MedicineGet { get; set; }
        public MedicinePostDto MedicinePost { get; set; }

        public MedicineUpdateDto()
        {
            MedicinePost = new MedicinePostDto();
        }
    }
}
