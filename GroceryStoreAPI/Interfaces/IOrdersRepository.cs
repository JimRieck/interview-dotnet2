using GroceryStoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreAPI.Interfaces
{
    public interface IOrdersRepository
    {
        List<Orders> GetAll();

        Orders GetById(int id);

        Orders Save(Orders model);
    }
}
