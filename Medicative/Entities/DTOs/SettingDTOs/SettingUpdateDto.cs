namespace Entities.DTOs.SettingDTOs
{
    public class SettingUpdateDto
    {
        public SettingGetDto SettingGet { get; set; }
        public SettingPostDto SettingPost { get; set; }
        public SettingUpdateDto()
        {
            SettingPost = new SettingPostDto();
        }
    }
}
