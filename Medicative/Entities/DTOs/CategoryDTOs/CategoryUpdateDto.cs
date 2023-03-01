namespace Entities.DTOs.CategoryDTOs
{
    public class CategoryUpdateDto
    {
        public CategoryGetDto CategoryGet { get; set; }
        public CategoryPostDto CategoryPost { get; set; }
        public CategoryUpdateDto()
        {
            CategoryPost = new CategoryPostDto();
        }
    }
}
