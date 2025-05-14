using Ardonagh_Task_Application.Models;
using Ardonagh_Task_Application.Models.ViewModels;

namespace Ardonagh_Task_Application.Services
{
    public interface ICustomerService
    {
        public CustomersViewModel GetCustomers();

        public CustomerRecord? GetCustomer(int id);

        public bool AddCustomer(CustomerRecord customer);

        public bool UpdateCustomer(CustomerRecord customer);
    }
}
