using Ardonagh_Task_Application.Models;
using Microsoft.EntityFrameworkCore;

using Ardonagh_Task_Application.DBContext;

namespace Ardonagh_Task_Application.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppDBContext appDBContext;


        public CustomerRepository(AppDBContext dBContext) {
            this.appDBContext = dBContext;
        }


        public bool AddCustomer(CustomerRecord customer)
        {
            appDBContext.Add(customer);
            appDBContext.SaveChanges();
            return true;
        }

        public CustomerRecord? GetCustomer(int id)
        {
            var customer = appDBContext.CustomerRecords
                .AsNoTracking()
                .SingleOrDefault(i => i.Id == id);
            return customer;
        }

        public List<CustomerRecord> GetCustomers()
        {
            var customers = appDBContext.CustomerRecords
                .AsNoTracking()
                .ToList();
            return customers;
        }

        public bool UpdateCustomer(CustomerRecord customer)
        {
            var customerToUpdate = appDBContext.CustomerRecords
                .SingleOrDefault(i => i.Id == customer.Id);
            if (customerToUpdate == null) { return false; }
            customerToUpdate.Name = customer.Name;
            customerToUpdate.Age = customer.Age;
            customerToUpdate.Postcode = customer.Postcode;
            customerToUpdate.Height = customer.Height;
            appDBContext.SaveChanges();
            return true;
        }
    }
}
