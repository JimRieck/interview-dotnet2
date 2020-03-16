using GroceryStoreAPI.Models;
using System.Collections.Generic;

namespace GroceryStoreAPI.Interfaces
{
    public interface IGroceryStoreService
    {
        GroceryStoreInfo Build();

        void Save(GroceryStoreInfo storeInfo);

    }
}
