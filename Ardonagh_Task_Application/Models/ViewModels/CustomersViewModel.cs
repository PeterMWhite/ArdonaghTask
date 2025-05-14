
namespace Ardonagh_Task_Application.Models.ViewModels
{
    public class CustomersViewModel
    {
        public List<CustomerRecord> CustomersList { get; set; }

        public CustomerRecord Customer { get; set; }

        public CustomersViewModel()
        {
            CustomersList = new List<CustomerRecord>();
        }
    }
}
