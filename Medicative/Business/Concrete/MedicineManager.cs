using AutoMapper;
using Business.Abstract;
using Core.Utilities.Abstract;
using Core.Utilities.Complex_types;
using Core.Utilities.Concrete;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using Entities.DTOs.DoctorDTOs;
using Entities.DTOs.MedicineDTOs;

namespace Business.Concrete
{
    public class MedicineManager : IMedicineService
    {
        private readonly IUnityOfWork _unityOfWork;
        private readonly IMapper _mapper;

        public MedicineManager(IUnityOfWork unityOfWork, IMapper mapper)
        {
            _unityOfWork = unityOfWork;
            _mapper = mapper;
        }

        public async Task<IDataResult<MedicineGetDto>> AddAsync(MedicinePostDto medicinePost)
        {
            if (medicinePost != null)
            {
                Medicine medicine = _mapper.Map<Medicine>(medicinePost);
                await _unityOfWork.Medicine.CreateAsync(medicine);
                await _unityOfWork.SaveAsync();

                MedicineGetDto medicineGet = _mapper.Map<MedicineGetDto>(medicine);

                return new DataResult<MedicineGetDto>(ResultStatus.Success, medicineGet);
            }

            return new DataResult<MedicineGetDto>(ResultStatus.Error, null, "These fields are required!!!");
        }

        public async Task<IResult> Delete(int id)
        {
            Medicine medicine = await _unityOfWork.Medicine.GetAsync(x => x.Id == id);

            if (medicine != null)
            {
                medicine.IsDeleted = true;
                _unityOfWork.Medicine.Update(medicine);
                await _unityOfWork.SaveAsync();

                return new Result(ResultStatus.Success);
            }

            return new Result(ResultStatus.Error, "There is no medicine in this id!");
        }

        public async Task<IDataResult<MedicineListDto>> GetAllAsync()
        {
            List<Medicine> medicines = await _unityOfWork.Medicine.GetAllAsync();
            MedicineListDto medicineList = new MedicineListDto()
            {
                MedicineList = _mapper.Map<List<MedicineGetDto>>(medicines)
            };

            return new DataResult<MedicineListDto>(ResultStatus.Success, medicineList);
        }

        public async Task<IDataResult<MedicineListDto>> GetAllByNonDeleteAsync(int id)
        {
            List<Medicine> medicines = await _unityOfWork.Medicine.GetAllAsync(x => !x.IsDeleted);
            MedicineListDto medicineList = new MedicineListDto()
            {
                MedicineList = _mapper.Map<List<MedicineGetDto>>(medicines)
            };

            return new DataResult<MedicineListDto>(ResultStatus.Success, medicineList);
        }

        public async Task<IDataResult<MedicineGetDto>> GetAsync(int id)
        {
            Medicine medicine = await _unityOfWork.Medicine.GetAsync(x => x.Id == id);

            if (medicine != null)
            {
                MedicineGetDto medicineGet = _mapper.Map<MedicineGetDto>(medicine);

                return new DataResult<MedicineGetDto>(ResultStatus.Success, medicineGet);
            }

            return new DataResult<MedicineGetDto>(ResultStatus.Error, null, "There is no medicine in this id!");
        }

        public Task<IDataResult<MedicineUpdateDto>> GetUpdateDto(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> HardDelete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<MedicineGetDto>> Update(MedicineUpdateDto medicineUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
