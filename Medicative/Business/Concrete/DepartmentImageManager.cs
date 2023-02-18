using AutoMapper;
using Business.Abstract;
using Core.Utilities.Abstract;
using Core.Utilities.Complex_types;
using Core.Utilities.Concrete;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using Entities.DTOs.CertificationDTOs;
using Entities.DTOs.DepartmentImageDTOs;

namespace Business.Concrete
{
    public class DepartmentImageManager : IDepartmentImageService
    {
        private readonly IUnityOfWork _unityOfWork;
        private readonly IMapper _mapper;

        public DepartmentImageManager(IUnityOfWork unityOfWork, IMapper mapper)
        {
            _unityOfWork = unityOfWork;
            _mapper = mapper;
        }

        public async Task<IDataResult<DepartmentImageGetDto>> AddAsync(DepartmentImagePostDto departmentImagePost)
        {
            if (departmentImagePost != null)
            {
                DepartmentImage departmentImage = _mapper.Map<DepartmentImage>(departmentImagePost);
                await _unityOfWork.DepartmentImage.CreateAsync(departmentImage);
                await _unityOfWork.SaveAsync();

                DepartmentImageGetDto departmentImageGet = _mapper.Map<DepartmentImageGetDto>(departmentImage);

                return new DataResult<DepartmentImageGetDto>(ResultStatus.Success, departmentImageGet);
            }

            return new DataResult<DepartmentImageGetDto>(ResultStatus.Error, null, "There are some problem, please check again!");
        }

        public async Task<IResult> Delete(int id)
        {
            DepartmentImage departmentImage = await _unityOfWork.DepartmentImage.GetAsync(x => x.Id == id);

            if (departmentImage != null)
            {
                departmentImage.IsDeleted = true;
                _unityOfWork.DepartmentImage.Update(departmentImage);
                await _unityOfWork.SaveAsync();

                return new Result(ResultStatus.Success);
            }

            return new Result(ResultStatus.Error, "There is no image in this id!");
        }

        public async Task<IDataResult<DepartmentImageListDto>> GetAllAsync()
        {
            List<DepartmentImage> departmentImages = await _unityOfWork.DepartmentImage.GetAllAsync();

            List<DepartmentImageGetDto> departmentImageGetList = _mapper.Map<List<DepartmentImageGetDto>>(departmentImages);

            return new DataResult<DepartmentImageListDto>(ResultStatus.Success, new DepartmentImageListDto { DepartmentImageList = departmentImageGetList });
        }

        public async Task<IDataResult<DepartmentImageListDto>> GetAllByNonDeleteAsync(int id)
        {
            List<DepartmentImage> departmentImages = await _unityOfWork.DepartmentImage.GetAllAsync(x => x.IsDeleted == false);

            List<DepartmentImageGetDto> departmentImageGetList = _mapper.Map<List<DepartmentImageGetDto>>(departmentImages);

            return new DataResult<DepartmentImageListDto>(ResultStatus.Success, new DepartmentImageListDto { DepartmentImageList = departmentImageGetList });
        }

        public async Task<IDataResult<DepartmentImageGetDto>> GetAsync(int id)
        {
            DepartmentImage departmentImage = await _unityOfWork.DepartmentImage.GetAsync(x => x.Id == id);

            if (departmentImage != null)
            {
                DepartmentImageGetDto departmentImageGet = _mapper.Map<DepartmentImageGetDto>(departmentImage);

                return new DataResult<DepartmentImageGetDto>(ResultStatus.Success, departmentImageGet);
            }

            return new DataResult<DepartmentImageGetDto>(ResultStatus.Error, null, "There is no image in this id!");
        }

        public async Task<IDataResult<DepartmentImageUpdateDto>> GetUpdateDto(int id)
        {
            DepartmentImage departmentImage = await _unityOfWork.DepartmentImage.GetAsync(x => x.Id == id);
            if (departmentImage is not null)
            {
                DepartmentImageUpdateDto departmentImageUpdate = new DepartmentImageUpdateDto()
                {
                    DepartmentImageGet = _mapper.Map<DepartmentImageGetDto>(departmentImage)
                };
                return new DataResult<DepartmentImageUpdateDto>(ResultStatus.Success, departmentImageUpdate);
            }
            return new DataResult<DepartmentImageUpdateDto>(ResultStatus.Error, null, "There is no image with this id");
        }

        public async Task<IResult> HardDelete(int id)
        {
            DepartmentImage departmentImage = await _unityOfWork.DepartmentImage.GetAsync(x => x.Id == id && x.IsDeleted);

            if (departmentImage != null)
            {
                _unityOfWork.DepartmentImage.Delete(departmentImage);
                await _unityOfWork.SaveAsync();

                return new Result(ResultStatus.Success);
            }

            return new Result(ResultStatus.Error, "There is no image in this id!");
        }

        public async Task<IDataResult<DepartmentImageGetDto>> Update(DepartmentImageUpdateDto departmentImageUpdate)
        {
            DepartmentImage departmentImage = await _unityOfWork.DepartmentImage.GetAsync(x => x.Id == departmentImageUpdate.DepartmentImageGet.Id);
            if (departmentImage is not null)
            {
                departmentImage = _mapper.Map<DepartmentImage>(departmentImageUpdate.DepartmentImagePost);
                departmentImageUpdate.DepartmentImageGet = _mapper.Map<DepartmentImageGetDto>(departmentImage);

                await _unityOfWork.SaveAsync();
                return new DataResult<DepartmentImageGetDto>(ResultStatus.Success, departmentImageUpdate.DepartmentImageGet);
            }
            return new DataResult<DepartmentImageGetDto>(ResultStatus.Error, null, "There id no image with this id");
        }
    }
}
