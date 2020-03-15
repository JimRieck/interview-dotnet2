using GroceryStoreAPI.Models;
using System.Collections.Generic;

namespace GroceryStoreAPI.Interfaces
{
    public interface IItemsRepository
    {
        List<Items> GetAll(string order);
    }
}
