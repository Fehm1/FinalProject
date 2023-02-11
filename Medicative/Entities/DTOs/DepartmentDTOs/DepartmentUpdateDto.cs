namespace Entities.DTOs.DepartmentDTOs
{
    public class DepartmentUpdateDto
    {
        public DepartmentGetDto DepartmentGet { get; set; }
        public DepartmentPostDto DepartmentPost { get; set; }

        public DepartmentUpdateDto()
        {
            DepartmentPost = new DepartmentPostDto(); 
        }
    }
}
