using AutoMapper;
using Business.Abstract;
using Core.Utilities.Abstract;
using Core.Utilities.Complex_types;
using Core.Utilities.Concrete;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using Entities.DTOs.DepartmentDTOs;

namespace Business.Concrete
{
    public class DepartmentManager : IDepartmentService
    {
        private readonly IUnityOfWork _unityOfWork;
        private readonly IMapper _mapper;

        public DepartmentManager(IUnityOfWork unityOfWork, IMapper mapper)
        {
            _unityOfWork = unityOfWork;
            _mapper = mapper;
        }

        
        public async Task<IResult> Delete(int id)
        {
            Department department = await _unityOfWork.Department.GetAsync(x => x.Id == id);

            if (department != null)
            {
                department.IsDeleted = true;
                _unityOfWork.Department.Update(department);
                await _unityOfWork.SaveAsync();

                return new Result(ResultStatus.Success);
            }

            return new Result(ResultStatus.Error, "There is no department in this id!");
        }

        public async Task<IDataResult<DepartmentListDto>> GetAllAsync()
        {
            List<Department> departments = await _unityOfWork.Department.GetAllAsync();

            List<DepartmentGetDto> departmentGetList = _mapper.Map<List<DepartmentGetDto>>(departments);

            return new DataResult<DepartmentListDto>(ResultStatus.Success, new DepartmentListDto { DepartmentList = departmentGetList });
        }

        public async Task<IDataResult<DepartmentListDto>> GetAllByNonDeleteAsync(int id)
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
                department = _mapper.Map<Department>(departmentUpdate.DepartmentPost);
                departmentUpdate.DepartmentGet = _mapper.Map<DepartmentGetDto>(department);

                await _unityOfWork.SaveAsync();
                return new DataResult<DepartmentGetDto>(ResultStatus.Success, departmentUpdate.DepartmentGet);
            }
            return new DataResult<DepartmentGetDto>(ResultStatus.Error, null, "There id no department in this id");
        }
    }
}
