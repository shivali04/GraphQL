using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orders.Models;

namespace Orders.Services
{
  public  class CustomerService : ICustomerService
    {
        private List<Customer> _customers;

        public CustomerService()
        {
            _customers.Add(new Customer(1, "KinetEco"));
            _customers.Add(new Customer(2, "Pixelford Photography"));
            _customers.Add(new Customer(3, "Topsy Turvy"));
            _customers.Add(new Customer(4, "Leaf & Mortar"));
        }
        public Customer GetCoustomerById(int id)
        {
            return GetCustomerByIdAsync(id).Result;
        }

        public Task<Customer> GetCustomerByIdAsync(int id)
        {
            return Task.FromResult(_customers.Single(o => Equals(o.Id, id)));
        }

        public Task<IEnumerable<Customer>> GetCustomersAsync()
        {
            return Task.FromResult(_customers.AsEnumerable());
        }
    }
    public interface ICustomerService
    {
        Customer GetCoustomerById(int id);
        Task<Customer> GetCustomerByIdAsync(int id); //allows to return tasks, for scalable, responsive APIs
        Task<IEnumerable<Customer>> GetCustomersAsync();
    }
}
