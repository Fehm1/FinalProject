namespace Entities.DTOs.SkillDTOs
{
    public class SkillUpdateDto
    {
        public SkillGetDto SkillGet { get; set; }
        public SkillPostDto SkillPost { get; set; }

        public SkillUpdateDto()
        {
            SkillPost = new SkillPostDto();
        }
    }
}
