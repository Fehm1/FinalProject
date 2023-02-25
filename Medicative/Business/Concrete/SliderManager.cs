using AutoMapper;
using Business.Abstract;
using Core.Utilities.Abstract;
using Core.Utilities.Complex_types;
using Core.Utilities.Concrete;
using Core.Utilities.Extensions.FileManagerExtentions;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using Entities.DTOs.ServiceDTOs;
using Entities.DTOs.SliderDTOs;
using Microsoft.AspNetCore.Hosting;
using System.Net;

namespace Business.Concrete
{
    public class SliderManager : ISliderService
    {
        private readonly IUnityOfWork _unityOfWork;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _env;

        public SliderManager(IUnityOfWork unityOfWork, IMapper mapper, IWebHostEnvironment env)
        {
            _unityOfWork = unityOfWork;
            _mapper = mapper;
            _env = env;
        }

        public async Task<IDataResult<SliderGetDto>> AddAsync(SliderPostDto sliderPost)
        {
            if (sliderPost != null)
            {
                Slider slider = _mapper.Map<Slider>(sliderPost);

                if (sliderPost.FormFile != null)
                {
                    if (!sliderPost.FormFile.IsImageContent())
                    {
                        return new DataResult<SliderGetDto>(ResultStatus.Error, null, "Image invalid format!");
                    }

                    if (!sliderPost.FormFile.IsValidImageLength())
                    {
                        return new DataResult<SliderGetDto>(ResultStatus.Error, null, "Image length must be less than 2 MB!");
                    }

                    slider.ImageUrl = sliderPost.FormFile.SaveImage(_env.WebRootPath, "uploads/sliders");
                }
                else
                {
                    return new DataResult<SliderGetDto>(ResultStatus.Error, null, "Image is required!");
                }

                await _unityOfWork.Slider.CreateAsync(slider);
                await _unityOfWork.SaveAsync();

                SliderGetDto sliderGet = _mapper.Map<SliderGetDto>(slider);

                return new DataResult<SliderGetDto>(ResultStatus.Success, sliderGet);
            }

            return new DataResult<SliderGetDto>(ResultStatus.Error, null, "There are some problem, please check again!");
        }

        public async Task<IResult> Delete(int id)
        {
            Slider slider = await _unityOfWork.Slider.GetAsync(x => x.Id == id);

            if (slider != null)
            {
                slider.IsDeleted = true;
                _unityOfWork.Slider.Update(slider);
                await _unityOfWork.SaveAsync();

                return new Result(ResultStatus.Success);
            }

            return new Result(ResultStatus.Error, "There is no slider in this id!");
        }

        public async Task<IDataResult<SliderListDto>> GetAllAsync()
        {
            List<Slider> sliders = await _unityOfWork.Slider.GetAllAsync();

            List<SliderGetDto> sliderGets = _mapper.Map<List<SliderGetDto>>(sliders);

            return new DataResult<SliderListDto>(ResultStatus.Success, new SliderListDto { SliderList = sliderGets });
        }

        public async Task<IDataResult<SliderListDto>> GetAllByNonDeleteAsync()
        {
            List<Slider> sliders = await _unityOfWork.Slider.GetAllAsync(x => x.IsDeleted == false);

            List<SliderGetDto> sliderGets = _mapper.Map<List<SliderGetDto>>(sliders);

            return new DataResult<SliderListDto>(ResultStatus.Success, new SliderListDto { SliderList = sliderGets });
        }

        public async Task<IDataResult<SliderListDto>> GetAllDeletedAsync()
        {
            List<Slider> sliders = await _unityOfWork.Slider.GetAllAsync(x => x.IsDeleted == true);

            List<SliderGetDto> sliderGets = _mapper.Map<List<SliderGetDto>>(sliders);

            return new DataResult<SliderListDto>(ResultStatus.Success, new SliderListDto { SliderList = sliderGets });
        }

        public async Task<IDataResult<SliderGetDto>> GetAsync(int id)
        {
            Slider slider = await _unityOfWork.Slider.GetAsync(x => x.Id == id);

            if (slider != null)
            {
                SliderGetDto sliderGet = _mapper.Map<SliderGetDto>(slider);

                return new DataResult<SliderGetDto>(ResultStatus.Success, sliderGet);
            }

            return new DataResult<SliderGetDto>(ResultStatus.Error, null, "There is no slider in this id!");
        }

        public async Task<IDataResult<SliderUpdateDto>> GetUpdateDto(int id)
        {
            Slider slider = await _unityOfWork.Slider.GetAsync(x => x.Id == id);
            if (slider is not null)
            {
                SliderUpdateDto sliderUpdate = new SliderUpdateDto()
                {
                    SliderGet = _mapper.Map<SliderGetDto>(slider)
                };
                return new DataResult<SliderUpdateDto>(ResultStatus.Success, sliderUpdate);
            }
            return new DataResult<SliderUpdateDto>(ResultStatus.Error, null, "There is no slider with this id");
        }

        public async Task<IResult> HardDelete(int id)
        {
            Slider slider = await _unityOfWork.Slider.GetAsync(x => x.Id == id);

            if (slider != null)
            {
                _unityOfWork.Slider.Delete(slider);
                await _unityOfWork.SaveAsync();

                return new Result(ResultStatus.Success);
            }

            return new Result(ResultStatus.Error, "There is no slider in this id!");
        }

        public async Task<IResult> Restore(int id)
        {
            Slider slider = await _unityOfWork.Slider.GetAsync(x => x.Id == id);

            if (slider != null)
            {
                slider.IsDeleted = false;
                _unityOfWork.Slider.Update(slider);
                await _unityOfWork.SaveAsync();

                return new Result(ResultStatus.Success);
            }

            return new Result(ResultStatus.Error, "There is no slider in this id!");
        }

        public async Task<IDataResult<SliderGetDto>> Update(SliderUpdateDto sliderUpdate)
        {
            Slider slider = await _unityOfWork.Slider.GetAsync(x => x.Id == sliderUpdate.SliderGet.Id);
            if (sliderUpdate is not null)
            {
                if (sliderUpdate.SliderPost.FormFile != null)
                {
                    if (!sliderUpdate.SliderPost.FormFile.IsImageContent())
                    {
                        return new DataResult<SliderGetDto>(ResultStatus.Error, null, "Image invalid format!");
                    }

                    if (!sliderUpdate.SliderPost.FormFile.IsValidImageLength())
                    {
                        return new DataResult<SliderGetDto>(ResultStatus.Error, null, "Image length must be less than 2 MB!");
                    }

                    string image = sliderUpdate.SliderPost.FormFile.SaveImage(_env.WebRootPath, "uploads/sliders");
                    slider.ImageUrl.DeleteImage(_env.WebRootPath, "uploads/sliders");
                    slider.ImageUrl = image;

                }

                slider.TitleWhite = sliderUpdate.SliderPost.TitleWhite;
                slider.TitleGreen = sliderUpdate.SliderPost.TitleGreen;
                slider.Description = sliderUpdate.SliderPost.Description;
                slider.RedirectURL = sliderUpdate.SliderPost.RedirectURL;
                slider.ModifiedTime = DateTime.Now;

                _unityOfWork.Slider.Update(slider);
                await _unityOfWork.SaveAsync();

                sliderUpdate.SliderGet = _mapper.Map<SliderGetDto>(slider);
                return new DataResult<SliderGetDto>(ResultStatus.Success, sliderUpdate.SliderGet);
            }
            return new DataResult<SliderGetDto>(ResultStatus.Error, null, "There id no slider with this id");
        }
    }
}
