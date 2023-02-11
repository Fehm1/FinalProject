namespace Entities.DTOs.DepartmentImageDTOs
{
    public class DepartmentImageUpdateDto
    {
        public DepartmentImageGetDto DepartmentImageGet { get; set; }
        public DepartmentImagePostDto DepartmentImagePost { get; set; }

        public DepartmentImageUpdateDto()
        {
            DepartmentImagePost = new DepartmentImagePostDto();
        }
    }
}
