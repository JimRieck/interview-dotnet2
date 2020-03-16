﻿using GroceryStoreAPI.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace GroceryStoreAPI.Repositories
{
    public class CustomerRepository : BaseRepository, ICustomerRepository 
    {
        public List<Customers> GetAll()
        {
            List<Customers> returnedCustomers = new List<Customers>();
            
            dynamic customers = this.ReadDataFromFile("customers");
          
            foreach (dynamic item in customers)
            {
                returnedCustomers.Add(new Customers { id = item.id, name = item.name });
            }

            return returnedCustomers;
            
        }

        public Customers GetById(int id)
        {
            return this.GetAll().FirstOrDefault(p => p.id == id);
        }

        public Customers Save(Customers customer) {
            return new Customers();
        }

       
    }
}
