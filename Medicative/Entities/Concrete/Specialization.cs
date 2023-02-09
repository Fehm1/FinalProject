using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Specialization : EntityBase, IEntity
    {
        public int DoctorId { get; set; }
        public string Text { get; set; }

        public Doctor Doctor { get; set; }
    }
}
