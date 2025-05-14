using Ardonagh_Task_Application.Models;
using Ardonagh_Task_Application.Models.ViewModels;
using Ardonagh_Task_Application.Repositories;

namespace Ardonagh_Task_Application.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public bool AddCustomer(CustomerRecord customer)
        {
            return customerRepository.AddCustomer(customer);
        }

        public CustomerRecord? GetCustomer(int id)
        {
            return customerRepository.GetCustomer(id);   
        }

        public CustomersViewModel GetCustomers()
        {
            var customers = customerRepository.GetCustomers();
            CustomersViewModel customersViewModel = new CustomersViewModel();
            foreach (var c in customers)
            {
                customersViewModel.CustomersList.Add(c);
            }
            return customersViewModel;
        }

        public bool UpdateCustomer(CustomerRecord customer)
        {
            return customerRepository.UpdateCustomer(customer);
        }
    }
}
