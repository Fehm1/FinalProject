using Business.Abstract;
using Core.Utilities.Abstract;
using Entities.DTOs.TrainingDTOs;

namespace Business.Concrete
{
    public class TrainingManager : ITrainingService
    {
        public Task<IDataResult<TrainingGetDto>> AddAsync(TrainingUpdateDto trainingUpdate)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<TrainingListDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<TrainingListDto>> GetAllByNonDeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<TrainingGetDto>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<TrainingUpdateDto>> GetUpdateDto(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> HardDelete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<TrainingGetDto>> Update(TrainingUpdateDto trainingUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
