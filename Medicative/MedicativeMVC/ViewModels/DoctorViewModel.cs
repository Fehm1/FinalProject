using Entities.Concrete;

namespace MedicativeMVC.ViewModels
{
    public class DoctorViewModel
    {
        public List<Doctor> Doctors { get; set; }
        public List<Setting> Settings { get; set; }
    }
}
