using GroceryStoreAPI.Models;
using System;
using System.Collections.Generic;

namespace GroceryStoreAPI.Interfaces
{
    public interface IGroceryStoreRepository
    {
        GroceryStoreInfo GetAll();

        GroceryStoreInfo GetById(int id);

        GroceryStoreInfo Save(GroceryStoreInfo storeInfo);


    }
}
