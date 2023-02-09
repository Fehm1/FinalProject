using Core.Entity.Abstract;

namespace Entities.Concrete
{
    public class Doctor : EntityBase, IEntity
    {
        public string FullName { get; set; }
        public int ProfessionId { get; set; }
        public int DepartmentId { get; set; }

        public string Phone { get; set; }
        public string Email { get; set; }
        public string ImageURL { get; set; }
        public string InstagramURL { get; set; }
        public string FacebookURL { get; set; }
        public string TwitterURL { get; set; }
        public string LinekedInURL { get; set; }
        public string RedirectURL { get; set; }

        public Profession Profession { get; set; }
        public Department Department { get; set; }
        public List<Specialization> Specializations { get; set; }
        public List<Skill> Skills { get; set; }
        public List<Education> Educations { get; set; }
        public List<Training> Training { get; set; }
        public List<Certification> Certifications { get; set; }
    }
}
