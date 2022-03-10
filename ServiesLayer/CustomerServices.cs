using DomainLayer;
using RepositoryLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiesLayer
{
    public class CustomerService : ICustomerServices
    {
        private readonly IRepository<Customer> _repository;
        public CustomerService(IRepository<Customer> repository)
        {
            _repository = repository;
        }
        public void DeleteCustomer(int id)
        {
            Customer customer = _repository.Get(id);
            _repository.Remove(customer);
            _repository.SaveChanges();
        }

        public Customer GetCustomer(int id)
        {
            return _repository.Get(id);
        }

        public IEnumerable<Customer> GetAllCustomer()
        {
            return _repository.Getall();
        }

        public void InsertCustomer(Customer customer)
        {
            _repository.Insert(customer);
            
        }

        public void UpdateCustomer(Customer customer)
        {
            _repository.Update(customer);
            
        }
    }
}
