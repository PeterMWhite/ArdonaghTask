using Ardonagh_Task_Application.Models;

namespace Ardonagh_Task_Application.Repositories
{
    public interface ICustomerRepository
    {
        public List<CustomerRecord> GetCustomers();

        public CustomerRecord? GetCustomer(int id);

        public bool AddCustomer(CustomerRecord customer);

        public bool UpdateCustomer(CustomerRecord customer);
    }
}
