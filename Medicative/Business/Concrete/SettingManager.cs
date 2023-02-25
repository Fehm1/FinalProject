using AutoMapper;
using Business.Abstract;
using Core.Utilities.Abstract;
using Core.Utilities.Complex_types;
using Core.Utilities.Concrete;
using Core.Utilities.Extensions.FileManagerExtentions;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using Entities.DTOs.CertificationDTOs;
using Entities.DTOs.CounterDTOs;
using Entities.DTOs.SettingDTOs;
using Microsoft.AspNetCore.Hosting;

namespace Business.Concrete
{
    public class SettingManager : ISettingService
    {
        private readonly IUnityOfWork _unityOfWork;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _env;

        public SettingManager(IUnityOfWork unityOfWork, IMapper mapper, IWebHostEnvironment env)
        {
            _unityOfWork = unityOfWork;
            _mapper = mapper;
            _env = env;
        }

        public async Task<IDataResult<SettingListDto>> GetAllAsync()
        {
            List<Setting> settings = await _unityOfWork.Setting.GetAllAsync();

            List<SettingGetDto> settingGetList = _mapper.Map<List<SettingGetDto>>(settings);

            return new DataResult<SettingListDto>(ResultStatus.Success, new SettingListDto { SettingList = settingGetList });
        }

        public async Task<IDataResult<SettingGetDto>> GetAsync(int id)
        {
            Setting setting = await _unityOfWork.Setting.GetAsync(x => x.Id == id);

            if (setting != null)
            {
                SettingGetDto settingGet = _mapper.Map<SettingGetDto>(setting);

                return new DataResult<SettingGetDto>(ResultStatus.Success, settingGet);
            }

            return new DataResult<SettingGetDto>(ResultStatus.Error, null, "There is no setting in this id!");
        }

        public async Task<IDataResult<SettingUpdateDto>> GetUpdateDto(int id)
        {
            Setting setting = await _unityOfWork.Setting.GetAsync(x => x.Id == id);
            if (setting is not null)
            {
                SettingUpdateDto settingUpdate = new SettingUpdateDto()
                {
                    SettingGet = _mapper.Map<SettingGetDto>(setting)
                };
                return new DataResult<SettingUpdateDto>(ResultStatus.Success, settingUpdate);
            }
            return new DataResult<SettingUpdateDto>(ResultStatus.Error, null, "There is no setting with this id");
        }

        public async Task<IDataResult<SettingGetDto>> Update(SettingUpdateDto settingUpdate)
        {
            Setting setting = await _unityOfWork.Setting.GetAsync(x => x.Id == settingUpdate.SettingGet.Id);
            if (setting is not null)
            {
                if (settingUpdate.SettingPost.FormFile != null)
                {
                    if (!settingUpdate.SettingPost.FormFile.IsImageContent())
                    {
                        return new DataResult<SettingGetDto>(ResultStatus.Error, null, "Image content isvalid!");
                    }

                    if (!settingUpdate.SettingPost.FormFile.IsValidImageLength())
                    {
                        return new DataResult<SettingGetDto>(ResultStatus.Error, null, "Image length must be less than 2Mb!");
                    }

                    string image = settingUpdate.SettingPost.FormFile.SaveImage(_env.WebRootPath, "uploads/settings");
                    setting.Value.DeleteImage(_env.WebRootPath, "uploads/settings");
                    setting.Value = image;
                }
                else
                {
                    setting.Value = settingUpdate.SettingPost.Value;
                }
                
                setting.ModifiedTime = DateTime.Now;

                settingUpdate.SettingGet = _mapper.Map<SettingGetDto>(setting);

                _unityOfWork.Setting.Update(setting);
                await _unityOfWork.SaveAsync();
                return new DataResult<SettingGetDto>(ResultStatus.Success, settingUpdate.SettingGet);
            }
            return new DataResult<SettingGetDto>(ResultStatus.Error, null, "There id no setting in this id");
        }
    }
}
