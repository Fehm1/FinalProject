using AutoMapper;
using Business.Abstract;
using Core.Utilities.Abstract;
using Core.Utilities.Complex_types;
using Core.Utilities.Concrete;
using Core.Utilities.Extensions.FileManagerExtentions;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using Entities.DTOs.CategoryDTOs;
using Entities.DTOs.ProductDTOs;
using Microsoft.AspNetCore.Hosting;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IUnityOfWork _unityOfWork;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _env;

        public ProductManager(IUnityOfWork unityOfWork, IMapper mapper, IWebHostEnvironment env)
        {
            _unityOfWork = unityOfWork;
            _mapper = mapper;
            _env = env;
        }
        public async Task<IDataResult<ProductGetDto>> AddAsync(ProductPostDto productPost)
        {

            if (productPost != null)
            {
                Product product = _mapper.Map<Product>(productPost);

                if (productPost.FormFile != null)
                {
                    if (!productPost.FormFile.IsImageContent())
                    {
                        return new DataResult<ProductGetDto>(ResultStatus.Error, null, "Image content!");
                    }

                    if (!productPost.FormFile.IsValidImageLength())
                    {
                        return new DataResult<ProductGetDto>(ResultStatus.Error, null, "Image length!");
                    }

                    product.ImageUrl = productPost.FormFile.SaveImage(_env.WebRootPath, "uploads/products"); ;
                }
                else
                {
                    return new DataResult<ProductGetDto>(ResultStatus.Error, null, "Image is required!");
                }

                await _unityOfWork.Product.CreateAsync(product);
                await _unityOfWork.SaveAsync();

                ProductGetDto productGet = _mapper.Map<ProductGetDto>(product);

                return new DataResult<ProductGetDto>(ResultStatus.Success, productGet);
            }

            return new DataResult<ProductGetDto>(ResultStatus.Error, null, "There are some problem, please check again!");
        }

        public async Task<IResult> Delete(int id)
        {
            Product product = await _unityOfWork.Product.GetAsync(x => x.Id == id);

            if (product != null)
            {
                product.IsDeleted = true;
                _unityOfWork.Product.Update(product);
                await _unityOfWork.SaveAsync();

                return new Result(ResultStatus.Success);
            }

            return new Result(ResultStatus.Error, "There is no product in this id!");
        }

        public async Task<IDataResult<ProductListDto>> GetAllAsync()
        {
            List<Product> products = await _unityOfWork.Product.GetAllAsync(null, x => x.Category);

            List<ProductGetDto> productGets = _mapper.Map<List<ProductGetDto>>(products);

            return new DataResult<ProductListDto>(ResultStatus.Success, new ProductListDto { ProductList = productGets });
        }

        public async Task<IDataResult<ProductListDto>> GetAllByNonDeleteAsync()
        {
            List<Product> products = await _unityOfWork.Product.GetAllAsync(x => x.IsDeleted == false, x => x.Category);

            List<ProductGetDto> productGets = _mapper.Map<List<ProductGetDto>>(products);

            return new DataResult<ProductListDto>(ResultStatus.Success, new ProductListDto { ProductList = productGets });
        }

        public async Task<IDataResult<ProductListDto>> GetAllDeletedAsync()
        {
            List<Product> products = await _unityOfWork.Product.GetAllAsync(x => x.IsDeleted == true, x => x.Category);

            List<ProductGetDto> productGets = _mapper.Map<List<ProductGetDto>>(products);

            return new DataResult<ProductListDto>(ResultStatus.Success, new ProductListDto { ProductList = productGets });
        }

        public async Task<IDataResult<ProductGetDto>> GetAsync(int id)
        {
            Product product = await _unityOfWork.Product.GetAsync(x => x.Id == id, x => x.Category);

            if (product != null)
            {
                ProductGetDto productGet = _mapper.Map<ProductGetDto>(product);

                return new DataResult<ProductGetDto>(ResultStatus.Success, productGet);
            }

            return new DataResult<ProductGetDto>(ResultStatus.Error, null, "There is no product in this id!");
        }

        public async Task<IDataResult<ProductUpdateDto>> GetUpdateDto(int id)
        {
            Product product = await _unityOfWork.Product.GetAsync(x => x.Id == id);
            if (product is not null)
            {
                ProductUpdateDto productUpdate = new ProductUpdateDto()
                {
                    ProductGet = _mapper.Map<ProductGetDto>(product)
                };
                return new DataResult<ProductUpdateDto>(ResultStatus.Success, productUpdate);
            }
            return new DataResult<ProductUpdateDto>(ResultStatus.Error, null, "There is no product with this id");
        }

        public async Task<IResult> HardDelete(int id)
        {
            Product product = await _unityOfWork.Product.GetAsync(x => x.Id == id);

            if (product != null)
            {
                _unityOfWork.Product.Delete(product);
                product.ImageUrl.DeleteImage(_env.WebRootPath, "uploads/products");
                await _unityOfWork.SaveAsync();

                return new Result(ResultStatus.Success);
            }

            return new Result(ResultStatus.Error, "There is no product in this id!");
        }

        public async Task<IResult> Restore(int id)
        {
            Product product = await _unityOfWork.Product.GetAsync(x => x.Id == id);

            if (product != null)
            {
                product.IsDeleted = false;
                _unityOfWork.Product.Update(product);
                await _unityOfWork.SaveAsync();

                return new Result(ResultStatus.Success);
            }

            return new Result(ResultStatus.Error, "There is no product in this id!");
        }

        public async Task<IDataResult<ProductGetDto>> Update(ProductUpdateDto productUpdate)
        {
            Product product = await _unityOfWork.Product.GetAsync(x => x.Id == productUpdate.ProductGet.Id);
            if (product is not null)
            {
                if (productUpdate.ProductPost.FormFile != null)
                {
                    if (!productUpdate.ProductPost.FormFile.IsImageContent())
                    {
                        return new DataResult<ProductGetDto>(ResultStatus.Error, null, "Image content!");
                    }

                    if (!productUpdate.ProductPost.FormFile.IsValidImageLength())
                    {
                        return new DataResult<ProductGetDto>(ResultStatus.Error, null, "Image length!");
                    }

                    string image = productUpdate.ProductPost.FormFile.SaveImage(_env.WebRootPath, "uploads/products");
                    product.ImageUrl.DeleteImage(_env.WebRootPath, "uploads/products");
                    product.ImageUrl = image;
                }

                product.CategoryId = productUpdate.ProductPost.CategoryId;
                product.Name = productUpdate.ProductPost.Name;
                product.Description = productUpdate.ProductPost.Description;
                product.Count = productUpdate.ProductPost.Count;
                product.DiscountPercent = productUpdate.ProductPost.DiscountPercent;
                product.Price = productUpdate.ProductPost.Price;
                product.IsPopular = productUpdate.ProductPost.IsPopular;
                product.TopSeller = productUpdate.ProductPost.TopSeller;
                product.ModifiedTime = DateTime.Now;

                productUpdate.ProductGet = _mapper.Map<ProductGetDto>(product);

                await _unityOfWork.SaveAsync();
                return new DataResult<ProductGetDto>(ResultStatus.Success, productUpdate.ProductGet);
            }
            return new DataResult<ProductGetDto>(ResultStatus.Error, null, "There id no product in this id");
        }
    }
}
