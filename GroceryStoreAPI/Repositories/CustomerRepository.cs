using GroceryStoreAPI.Interfaces;
using GroceryStoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GroceryStoreAPI.Repositories
{
    public class CustomerRepository : BaseRepository
    {
        public override GroceryStoreInfo GetAll()
        {
            GroceryStoreInfo info = new GroceryStoreInfo();
            List<Customers> returnedCustomers = new List<Customers>();

            dynamic customers = ReadDataFromFile("customers");
          
            foreach (dynamic item in customers)
            {
                returnedCustomers.Add(new Customers { id = item.id, name = item.name });
            }

            info.Customers = returnedCustomers;
            return info;
        }

        public override GroceryStoreInfo GetById(int id)
        {
            GroceryStoreInfo info = new GroceryStoreInfo();
            info = this.GetAll();
            info.Customers = info.Customers.Where(p => p.id == id).ToList();
            return info;
        }

        public GroceryStoreInfo Save()
        {
            throw new NotImplementedException();
        }
    }
}
