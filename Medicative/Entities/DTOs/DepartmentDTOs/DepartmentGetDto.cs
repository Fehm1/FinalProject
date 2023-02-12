﻿using Entities.Concrete;

namespace Entities.DTOs.DepartmentDTOs
{
    public class DepartmentGetDto
    {
        public virtual int Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public int InvestigationFee { get; set; }
        public int TreatmentFee { get; set; }
        public string RedirectURL { get; set; }

        public virtual DateTime CreatedTime { get; set; } = DateTime.Now;
        public virtual DateTime ModifiedTime { get; set; } = DateTime.Now;
        public virtual bool IsActive { get; set; } = false;
        public virtual bool IsDeleted { get; set; } = false;

        public List<DepartmentImage>? Images { get; set; }
        public List<Doctor>? Doctors { get; set; }
    }
}
