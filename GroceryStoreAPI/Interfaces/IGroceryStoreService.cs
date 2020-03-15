using GroceryStoreAPI.Models;
using System.Collections.Generic;

namespace GroceryStoreAPI.Interfaces
{
    public interface IGroceryStoreService
    {
        GroceryStoreInfo Build();

        List<GroceryStoreInfo> GetByCustomerId(int id);

        GroceryStoreInfo Save(GroceryStoreInfo storeInfo);
    }
}
