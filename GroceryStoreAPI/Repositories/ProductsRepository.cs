using GroceryStoreAPI.Interfaces;
using GroceryStoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreAPI.Repositories
{
    public class ProductsRepository : BaseRepository, IRepository<Products>
    {
        public List<Products> Get(Func<Products, bool> condition = null)
        {
            throw new NotImplementedException();
        }

        public Products Save()
        {
            throw new NotImplementedException();
        }
    }
}
