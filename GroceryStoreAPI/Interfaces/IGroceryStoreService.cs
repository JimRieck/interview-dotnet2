using GroceryStoreAPI.Models;
using System;
using System.Collections.Generic;

namespace GroceryStoreAPI.Interfaces
{
    public interface IGroceryStoreService
    {
        GroceryStoreInfo Build();

        List<GroceryStoreInfo> GetByCustomerId(int id);

        void Save(GroceryStoreInfo storeInfo);

    }
}
