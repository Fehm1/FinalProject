using AutoMapper;
using Business.Abstract;
using Core.Utilities.Abstract;
using Core.Utilities.Complex_types;
using Core.Utilities.Concrete;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using Entities.DTOs.MedicineCategoryDTOs;

namespace Business.Concrete
{
    public class MedicineCategoryManager : IMedicineCategoryService
    {
        private readonly IUnityOfWork _unityOfWork;
        private readonly IMapper _mapper;

        public MedicineCategoryManager(IUnityOfWork unityOfWork, IMapper mapper)
        {
            _unityOfWork = unityOfWork;
            _mapper = mapper;
        }

        public async Task<IDataResult<MedicineCategoryGetDto>> AddAsync(MedicineCategoryPostDto medicineCategoryPost)
        {
            if (medicineCategoryPost != null)
            {
                MedicineCategory medicineCategory = _mapper.Map<MedicineCategory>(medicineCategoryPost);
                await _unityOfWork.MedicineCategory.CreateAsync(medicineCategory);
                await _unityOfWork.SaveAsync();

                MedicineCategoryGetDto medicineCategoryGet = _mapper.Map<MedicineCategoryGetDto>(medicineCategory);

                return new DataResult<MedicineCategoryGetDto>(ResultStatus.Success, medicineCategoryGet);
            }

            return new DataResult<MedicineCategoryGetDto>(ResultStatus.Error, null, "These fields are required!!!");
        }

        public async Task<IResult> Delete(int id)
        {
            MedicineCategory medicineCategory = await _unityOfWork.MedicineCategory.GetAsync(x => x.Id == id);

            if (medicineCategory != null)
            {
                medicineCategory.IsDeleted = true;
                _unityOfWork.MedicineCategory.Update(medicineCategory);
                await _unityOfWork.SaveAsync();

                return new Result(ResultStatus.Success);
            }

            return new Result(ResultStatus.Error, "There is no category in this id!");
        }

        public async Task<IDataResult<MedicineCategoryListDto>> GetAllAsync()
        {
            List<MedicineCategory> medicineCategories = await _unityOfWork.MedicineCategory.GetAllAsync();
            MedicineCategoryListDto medicineCategoryList = new MedicineCategoryListDto()
            {
                MedicineCategoryList = _mapper.Map<List<MedicineCategoryGetDto>>(medicineCategories)
            };

            return new DataResult<MedicineCategoryListDto>(ResultStatus.Success, medicineCategoryList);
        }

        public async Task<IDataResult<MedicineCategoryListDto>> GetAllByNonDeleteAsync(int id)
        {
            List<MedicineCategory> medicineCategories = await _unityOfWork.MedicineCategory.GetAllAsync(x => !x.IsDeleted);
            MedicineCategoryListDto medicineCategoryList = new MedicineCategoryListDto()
            {
                MedicineCategoryList = _mapper.Map<List<MedicineCategoryGetDto>>(medicineCategories)
            };

            return new DataResult<MedicineCategoryListDto>(ResultStatus.Success, medicineCategoryList);
        }

        public async Task<IDataResult<MedicineCategoryGetDto>> GetAsync(int id)
        {
            MedicineCategory medicineCategory = await _unityOfWork.MedicineCategory.GetAsync(x => x.Id == id);

            if (medicineCategory != null)
            {
                MedicineCategoryGetDto medicineCategoryGet = _mapper.Map<MedicineCategoryGetDto>(medicineCategory);

                return new DataResult<MedicineCategoryGetDto>(ResultStatus.Success, medicineCategoryGet);
            }

            return new DataResult<MedicineCategoryGetDto>(ResultStatus.Error, null, "There is no category in this id!");
        }

        public async Task<IDataResult<MedicineCategoryUpdateDto>> GetUpdateDto(int id)
        {
            MedicineCategory medicineCategory = await _unityOfWork.MedicineCategory.GetAsync(x => x.Id == id);
            if (medicineCategory is not null)
            {
                MedicineCategoryUpdateDto medicineCategoryUpdate = new MedicineCategoryUpdateDto()
                {
                    MedicineCategoryGet = _mapper.Map<MedicineCategoryGetDto>(medicineCategory)
                };
                return new DataResult<MedicineCategoryUpdateDto>(ResultStatus.Success, medicineCategoryUpdate);
            }
            return new DataResult<MedicineCategoryUpdateDto>(ResultStatus.Error, null, "There is no category with this id");
        }

        public async Task<IResult> HardDelete(int id)
        {
            MedicineCategory medicineCategory = await _unityOfWork.MedicineCategory.GetAsync(x => x.Id == id && x.IsDeleted);

            if (medicineCategory != null)
            {
                _unityOfWork.MedicineCategory.Delete(medicineCategory);
                await _unityOfWork.SaveAsync();

                return new Result(ResultStatus.Success);
            }

            return new Result(ResultStatus.Error, "There is no category in this id!");
        }

        public async Task<IDataResult<MedicineCategoryGetDto>> Update(MedicineCategoryUpdateDto medicineCategoryUpdate)
        {
            MedicineCategory medicineCategory = await _unityOfWork.MedicineCategory.GetAsync(x => x.Id == medicineCategoryUpdate.MedicineCategoryGet.Id);
            if (medicineCategoryUpdate is not null)
            {
                medicineCategory = _mapper.Map<MedicineCategory>(medicineCategoryUpdate.MedicineCategoryPost);
                medicineCategoryUpdate.MedicineCategoryGet = _mapper.Map<MedicineCategoryGetDto >(medicineCategory);

                await _unityOfWork.SaveAsync();
                return new DataResult<MedicineCategoryGetDto >(ResultStatus.Success, medicineCategoryUpdate.MedicineCategoryGet);
            }
            return new DataResult<MedicineCategoryGetDto>(ResultStatus.Error, null, "There id no category in this id");
        }
    }
}
