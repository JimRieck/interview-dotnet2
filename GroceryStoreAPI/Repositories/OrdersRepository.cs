using GroceryStoreAPI.Interfaces;
using GroceryStoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreAPI.Repositories
{
    public class OrdersRepository : BaseRepository, IRepository<Orders>
    {
        public List<Orders> Get(Func<Orders, bool> condition = null)
        {
            List<Orders> returnedCustomers = new List<Orders>();

            dynamic orders = ReadDataFromFile("orders");

            foreach (dynamic item in orders)
            {
                returnedCustomers.Add(new Orders { Id = item.id, CustomerId = item.customerId });
            }

            if (condition != null)
            {
                returnedCustomers = returnedCustomers.Where(condition).ToList();
            }

            return returnedCustomers;
        }

        public Orders Save()
        {
            throw new NotImplementedException();
        }
    }
}
