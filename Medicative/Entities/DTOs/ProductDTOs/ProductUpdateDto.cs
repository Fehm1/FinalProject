namespace Entities.DTOs.ProductDTOs
{
    public class ProductUpdateDto
    {
        public ProductGetDto ProductGet { get; set; }
        public ProductPostDto ProductPost { get; set; }
        public ProductUpdateDto()
        {
            ProductPost = new ProductPostDto();
        }
    }
}
