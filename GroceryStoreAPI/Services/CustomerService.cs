using GroceryStoreAPI.Interfaces;
using GroceryStoreAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreAPI.Services
{
    public class CustomerService : IService<Customers>
    {
        IRepository<Customers> customerRepository;
        

        public CustomerService(IRepository<Customers> customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public List<Customers> GetAll()
        {
            return this.customerRepository.Get(null);
          
        }

        public Customers GetById(int customerId)
        {
            return this.customerRepository.Get(p => p.id == customerId).FirstOrDefault();
        }

        public Customers Save()
        {
            throw new NotImplementedException();
        }
    }
}
