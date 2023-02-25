namespace Entities.DTOs.SettingDTOs
{
    public class SettingGetDto
    {
        public virtual int Id { get; set; }

        public string Key { get; set; }
        public string Value { get; set; }
        
        public virtual DateTime CreatedTime { get; set; } = DateTime.Now;
        public virtual DateTime ModifiedTime { get; set; } = DateTime.Now;
        public virtual bool IsActive { get; set; } = false;
        public virtual bool IsDeleted { get; set; } = false;
    }
}
