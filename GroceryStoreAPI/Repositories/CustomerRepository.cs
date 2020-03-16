using GroceryStoreAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;

namespace GroceryStoreAPI.Repositories
{
    public class CustomerRepository : DataRepository<Customers> 
    {
        public override List<Customers> GetAll() 
        {
            List<Customers> returnedCustomers = new List<Customers>();
            
            dynamic customers = jsonFileReader.ReadDataFromFile("customers");
          
            foreach (dynamic item in customers)
            {
                returnedCustomers.Add(new Customers { id = item.id, name = item.name });
            }
          
          
            return returnedCustomers;
            
        }
    }
}
