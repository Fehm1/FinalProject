using Core.Entity.Abstract;

namespace Entities.Concrete
{
    public class Doctor : EntityBase, IEntity
    {
        public int ProfessionId { get; set; }
        public int DepartmentId { get; set; }

        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string ImageURL { get; set; }
        public string InstagramURL { get; set; }
        public string FacebookURL { get; set; }
        public string TwitterURL { get; set; }
        public string LinekedInURL { get; set; }

        public Profession Profession { get; set; }
        public Department Department { get; set; }
        public List<Specialization> Specializations { get; set; } = new List<Specialization>();
        public List<Education> Educations { get; set; } = new List<Education>();
        public List<Training> Training { get; set; } = new List<Training>(); 
        public List<Certification> Certifications { get; set; } = new List<Certification>();
    }
}
