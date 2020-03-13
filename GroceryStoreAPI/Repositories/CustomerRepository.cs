using GroceryStoreAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GroceryStoreAPI.Repositories
{
    public class CustomerRepository : BaseRepository, IRepository<Customers>
    {
        public List<Customers> Get(Func<Customers, bool> condition = null)
        {
            List<Customers> returnedCustomers = new List<Customers>();

            dynamic customers = ReadDataFromFile("customers");
          
            foreach (dynamic item in customers)
            {
                returnedCustomers.Add(new Customers { id = item.id, name = item.name });
            }

            if (condition != null)
            {
                returnedCustomers = returnedCustomers.Where(condition).ToList();
            }

            return returnedCustomers;
        }

        public Customers Save()
        {
            throw new NotImplementedException();
        }
    }
}
