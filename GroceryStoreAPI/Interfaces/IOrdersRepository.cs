using GroceryStoreAPI.Models;
using System.Collections.Generic;

namespace GroceryStoreAPI.Interfaces
{
    public interface IOrdersRepository
    {
        List<Orders> GetAll();

    }
}
