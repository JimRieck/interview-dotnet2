using GroceryStoreAPI.Interfaces;
using GroceryStoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreAPI.Services
{
    public class BaseService
    {
        public virtual GroceryStoreInfo GetAll()
        {
            throw new NotImplementedException();
        }

        public virtual List<GroceryStoreInfo> GetById()
        {
            throw new NotImplementedException();
        }

        public virtual GroceryStoreInfo Save(GroceryStoreInfo storeInfo)
        {
            throw new NotImplementedException();
        }
    }
}
