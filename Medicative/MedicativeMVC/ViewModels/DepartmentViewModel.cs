using Entities.Concrete;

namespace MedicativeMVC.ViewModels
{
    public class DepartmentViewModel
    {
        public List<Department> Departments { get; set; }
        public List<Doctor> Doctors { get; set; }
        public List<Counter> Counters { get; set; }
        public List<Setting> Settings { get; set; }
    }
}
