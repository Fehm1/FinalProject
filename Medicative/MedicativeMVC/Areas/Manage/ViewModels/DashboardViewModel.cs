using Entities.Concrete;

namespace MedicativeMVC.Areas.Manage.ViewModels
{
    public class DashboardViewModel
    {
        public int Doctors { get; set; }
        public int Departments { get; set; }
        public int Products { get; set; }
        public int Orders { get; set; }
        public int Messages { get; set; }
    }
}
