using GroceryStoreAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreAPI.Repositories
{
    public class OrdersRepository : IRepository<OrdersRepository>
    {
       
        IEnumerable<OrdersRepository> IRepository<OrdersRepository>.GetAll()
        {
            throw new NotImplementedException();
        }

        OrdersRepository IRepository<OrdersRepository>.GetById()
        {
            throw new NotImplementedException();
        }

        OrdersRepository IRepository<OrdersRepository>.Save()
        {
            throw new NotImplementedException();
        }
    }
}
