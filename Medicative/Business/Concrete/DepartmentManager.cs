using AutoMapper;
using Business.Abstract;
using Core.Utilities.Abstract;
using Core.Utilities.Complex_types;
using Core.Utilities.Concrete;
using Core.Utilities.Extensions.FileManagerExtentions;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using Entities.DTOs.DepartmentDTOs;
using Microsoft.AspNetCore.Hosting;

namespace Business.Concrete
{
    public class DepartmentManager : IDepartmentService
    {
        private readonly IUnityOfWork _unityOfWork;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _env;

        public DepartmentManager(IUnityOfWork unityOfWork, IMapper mapper, IWebHostEnvironment env)
        {
            _unityOfWork = unityOfWork;
            _mapper = mapper;
            _env = env;
        }

        
        public async Task<IDataResult<DepartmentListDto>> GetAllAsync()
        {
            List<Department> departments = await _unityOfWork.Department.GetAllAsync();

            List<DepartmentGetDto> departmentGetList = _mapper.Map<List<DepartmentGetDto>>(departments);

            return new DataResult<DepartmentListDto>(ResultStatus.Success, new DepartmentListDto { DepartmentList = departmentGetList });
        }

        public async Task<IDataResult<DepartmentListDto>> GetAllByNonDeleteAsync()
        {
            List<Department> departments = await _unityOfWork.Department.GetAllAsync(x => x.IsDeleted == false);

            List<DepartmentGetDto> departmentGetList = _mapper.Map<List<DepartmentGetDto>>(departments);

            return new DataResult<DepartmentListDto>(ResultStatus.Success, new DepartmentListDto { DepartmentList = departmentGetList });
        }

        public async Task<IDataResult<DepartmentGetDto>> GetAsync(int id)
        {
            Department department = await _unityOfWork.Department.GetAsync(x => x.Id == id);

            if (department != null)
            {
                DepartmentGetDto departmentGet = _mapper.Map<DepartmentGetDto>(department);

                return new DataResult<DepartmentGetDto>(ResultStatus.Success, departmentGet);
            }

            return new DataResult<DepartmentGetDto>(ResultStatus.Error, null, "There is no department in this id!");
        }

        public async Task<IDataResult<DepartmentUpdateDto>> GetUpdateDto(int id)
        {
            Department department = await _unityOfWork.Department.GetAsync(x => x.Id == id);
            if (department is not null)
            {
                DepartmentUpdateDto departmentUpdate = new DepartmentUpdateDto()
                {
                    DepartmentGet = _mapper.Map<DepartmentGetDto>(department)
                };
                return new DataResult<DepartmentUpdateDto>(ResultStatus.Success, departmentUpdate);
            }
            return new DataResult<DepartmentUpdateDto>(ResultStatus.Error, null, "There is no department with this id");
        }

        public async Task<IDataResult<DepartmentGetDto>> Update(DepartmentUpdateDto departmentUpdate)
        {
            Department department = await _unityOfWork.Department.GetAsync(x => x.Id == departmentUpdate.DepartmentGet.Id);
            if (departmentUpdate is not null)
            {
                if (departmentUpdate.DepartmentPost.PosterFormFile != null)
                {
                    if (!departmentUpdate.DepartmentPost.PosterFormFile.IsImageContent())
                    {
                        return new DataResult<DepartmentGetDto>(ResultStatus.Error, null, "Image context incorrect!");
                    }

                    if (!departmentUpdate.DepartmentPost.PosterFormFile.IsValidImageLength())
                    {
                        return new DataResult<DepartmentGetDto>(ResultStatus.Error, null, "Image length must be less than 2MB!");
                    }

                    string image = departmentUpdate.DepartmentPost.PosterFormFile.SaveImage(_env.WebRootPath, "uploads/departments");
                    department.PosterImage.DeleteImage(_env.WebRootPath, "uploads/departments");
                    department.PosterImage = image;
                }

                if (departmentUpdate.DepartmentPost.DetailFormFile != null)
                {
                    if (!departmentUpdate.DepartmentPost.DetailFormFile.IsImageContent())
                    {
                        return new DataResult<DepartmentGetDto>(ResultStatus.Error, null, "Image context incorrect!");
                    }

                    if (!departmentUpdate.DepartmentPost.DetailFormFile.IsValidImageLength())
                    {
                        return new DataResult<DepartmentGetDto>(ResultStatus.Error, null, "Image length must be less than 2MB!");
                    }

                    string image = departmentUpdate.DepartmentPost.DetailFormFile.SaveImage(_env.WebRootPath, "uploads/departments");
                    department.DetailImage.DeleteImage(_env.WebRootPath, "uploads/departments");
                    department.DetailImage = image;
                }

                department.Title = departmentUpdate.DepartmentPost.Title;
                department.Description = departmentUpdate.DepartmentPost.Description;
                department.InvestigationFee = departmentUpdate.DepartmentPost.InvestigationFee;
                department.TreatmentFee = departmentUpdate.DepartmentPost.TreatmentFee;
                department.RedirectUrl = departmentUpdate.DepartmentPost.RedirectUrl;
                department.ModifiedTime = DateTime.Now;

                departmentUpdate.DepartmentGet = _mapper.Map<DepartmentGetDto>(department);

                _unityOfWork.Department.Update(department);
                await _unityOfWork.SaveAsync();
                return new DataResult<DepartmentGetDto>(ResultStatus.Success, departmentUpdate.DepartmentGet);
            }
            return new DataResult<DepartmentGetDto>(ResultStatus.Error, null, "There id no department in this id");
        }
    }
}
