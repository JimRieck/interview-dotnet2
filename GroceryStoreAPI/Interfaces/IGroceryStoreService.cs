using GroceryStoreAPI.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreAPI.Interfaces
{
    public interface IGroceryStoreService
    {
        GroceryStoreInfo Build();

        List<GroceryStoreInfo> GetByCustomerId(int id);

        GroceryStoreInfo Save(GroceryStoreInfo storeInfo);
    }
}
