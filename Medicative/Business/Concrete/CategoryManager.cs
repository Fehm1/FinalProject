using AutoMapper;
using Business.Abstract;
using Core.Utilities.Abstract;
using Core.Utilities.Complex_types;
using Core.Utilities.Concrete;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using Entities.DTOs.CategoryDTOs;
using Entities.DTOs.CertificationDTOs;
using Microsoft.AspNetCore.Hosting;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly IUnityOfWork _unityOfWork;
        private readonly IMapper _mapper;

        public CategoryManager(IUnityOfWork unityOfWork, IMapper mapper)
        {
            _unityOfWork = unityOfWork;
            _mapper = mapper;
        }

        public async Task<IDataResult<CategoryGetDto>> AddAsync(CategoryPostDto categoryPost)
        {
            if (categoryPost != null)
            {
                Category category = _mapper.Map<Category>(categoryPost);
                await _unityOfWork.Category.CreateAsync(category);
                await _unityOfWork.SaveAsync();

                CategoryGetDto categoryGet = _mapper.Map<CategoryGetDto>(category);

                return new DataResult<CategoryGetDto>(ResultStatus.Success, categoryGet);
            }

            return new DataResult<CategoryGetDto>(ResultStatus.Error, null, "There are some problem, please check again!");
        }

        public async Task<IResult> Delete(int id)
        {
            Category category = await _unityOfWork.Category.GetAsync(x => x.Id == id);

            if (category != null)
            {
                category.IsDeleted = true;
                _unityOfWork.Category.Update(category);
                await _unityOfWork.SaveAsync();

                return new Result(ResultStatus.Success);
            }

            return new Result(ResultStatus.Error, "There is no category in this id!");
        }

        public async Task<IDataResult<CategoryListDto>> GetAllAsync()
        {
            List<Category> categories = await _unityOfWork.Category.GetAllAsync();

            List<CategoryGetDto> categoryGets = _mapper.Map<List<CategoryGetDto>>(categories);

            return new DataResult<CategoryListDto>(ResultStatus.Success, new CategoryListDto { CategoryGets = categoryGets });
        }

        public async Task<IDataResult<CategoryListDto>> GetAllByNonDeleteAsync()
        {
            List<Category> categories = await _unityOfWork.Category.GetAllAsync(x => x.IsDeleted == false);

            List<CategoryGetDto> categoryGets = _mapper.Map<List<CategoryGetDto>>(categories);

            return new DataResult<CategoryListDto>(ResultStatus.Success, new CategoryListDto { CategoryGets = categoryGets });
        }

        public async Task<IDataResult<CategoryListDto>> GetAllDeletedAsync()
        {
            List<Category> categories = await _unityOfWork.Category.GetAllAsync(x => x.IsDeleted == true);

            List<CategoryGetDto> categoryGets = _mapper.Map<List<CategoryGetDto>>(categories);

            return new DataResult<CategoryListDto>(ResultStatus.Success, new CategoryListDto { CategoryGets = categoryGets });
        }

        public async Task<IDataResult<CategoryGetDto>> GetAsync(int id)
        {
            Category category = await _unityOfWork.Category.GetAsync(x => x.Id == id);

            if (category != null)
            {
                CategoryGetDto categoryGet = _mapper.Map<CategoryGetDto>(category);

                return new DataResult<CategoryGetDto>(ResultStatus.Success, categoryGet);
            }

            return new DataResult<CategoryGetDto>(ResultStatus.Error, null, "There is no category in this id!");
        }

        public async Task<IDataResult<CategoryUpdateDto>> GetUpdateDto(int id)
        {
            Category category = await _unityOfWork.Category.GetAsync(x => x.Id == id);
            if (category is not null)
            {
                CategoryUpdateDto categoryUpdate = new CategoryUpdateDto()
                {
                    CategoryGet = _mapper.Map<CategoryGetDto>(category)
                };
                return new DataResult<CategoryUpdateDto>(ResultStatus.Success, categoryUpdate);
            }
            return new DataResult<CategoryUpdateDto>(ResultStatus.Error, null, "There is no category with this id");
        }

        public async Task<IResult> HardDelete(int id)
        {
            Category category = await _unityOfWork.Category.GetAsync(x => x.Id == id);

            if (category != null)
            {
                _unityOfWork.Category.Delete(category);
                await _unityOfWork.SaveAsync();

                return new Result(ResultStatus.Success);
            }

            return new Result(ResultStatus.Error, "There is no category in this id!");
        }

        public async Task<IResult> Restore(int id)
        {
            Category category = await _unityOfWork.Category.GetAsync(x => x.Id == id);

            if (category != null)
            {
                category.IsDeleted = false;
                _unityOfWork.Category.Update(category);
                await _unityOfWork.SaveAsync();

                return new Result(ResultStatus.Success);
            }

            return new Result(ResultStatus.Error, "There is no category in this id!");
        }

        public async Task<IDataResult<CategoryGetDto>> Update(CategoryUpdateDto categoryUpdate)
        {
            Category category = await _unityOfWork.Category.GetAsync(x => x.Id == categoryUpdate.CategoryGet.Id);
            if (category is not null)
            {
                category.Name = categoryUpdate.CategoryPost.Name;
                category.ModifiedTime = DateTime.Now;

                categoryUpdate.CategoryGet = _mapper.Map<CategoryGetDto>(category);

                _unityOfWork.Category.Update(category);
                await _unityOfWork.SaveAsync();
                return new DataResult<CategoryGetDto>(ResultStatus.Success, categoryUpdate.CategoryGet);
            }
            return new DataResult<CategoryGetDto>(ResultStatus.Error, null, "There id no category in this id");
        }
    }
}
