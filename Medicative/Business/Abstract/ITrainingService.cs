using Core.Utilities.Abstract;
using Entities.DTOs.TrainingDTOs;

namespace Business.Abstract
{
    public interface ITrainingService
    {
        Task<IDataResult<TrainingGetDto>> GetAsync(int id);
        Task<IDataResult<TrainingListDto>> GetAllAsync();
        Task<IDataResult<TrainingListDto>> GetAllByNonDeleteAsync(int id);
        Task<IDataResult<TrainingUpdateDto>> GetUpdateDto(int id);
        Task<IDataResult<TrainingGetDto>> AddAsync(TrainingUpdateDto trainingUpdate);
        Task<IDataResult<TrainingGetDto>> Update(TrainingUpdateDto trainingUpdate);
        Task<IResult> Delete(int id);
        Task<IResult> HardDelete(int id);
    }
}
