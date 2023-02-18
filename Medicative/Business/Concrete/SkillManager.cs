using Business.Abstract;
using Core.Utilities.Abstract;
using Entities.DTOs.SkillDTOs;

namespace Business.Concrete
{
    public class SkillManager : ISkillService
    {
        public Task<IDataResult<SkillGetDto>> AddAsync(SkillUpdateDto skillUpdate)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SkillListDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SkillListDto>> GetAllByNonDeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SkillGetDto>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SkillUpdateDto>> GetUpdateDto(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> HardDelete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SkillGetDto>> Update(SkillUpdateDto skillUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
