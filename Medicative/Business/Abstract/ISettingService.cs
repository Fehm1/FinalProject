using Core.Utilities.Abstract;
using Entities.DTOs.SettingDTOs;
using Entities.DTOs.SliderDTOs;

namespace Business.Abstract
{
    public interface ISettingService
    {
        Task<IDataResult<SettingGetDto>> GetAsync(int id);
        Task<IDataResult<SettingListDto>> GetAllAsync();
        Task<IDataResult<SettingUpdateDto>> GetUpdateDto(int id);
        Task<IDataResult<SettingGetDto>> Update(SettingUpdateDto settingUpdate);
    }
}
