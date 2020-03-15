using GroceryStoreAPI.Interfaces;
using GroceryStoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreAPI.Repositories
{
    public class GroceryStoreRepository : IGroceryStoreRepository
    {
        public virtual GroceryStoreInfo GetAll()
        {
            throw new NotImplementedException();
        }

        public virtual GroceryStoreInfo GetById(int id)
        {
            throw new NotImplementedException();
        }

        public GroceryStoreInfo Save(GroceryStoreInfo storeInfo)
        {
            throw new NotImplementedException();
        }
    }
}
