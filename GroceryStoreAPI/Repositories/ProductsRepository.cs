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
            List<Products> returnedProducts = new List<Products>();

            dynamic products = ReadDataFromFile("products");

            foreach (dynamic item in products)
            {
                returnedProducts.Add(new Products { Id = item.id, Description = item.description, Price = item.price });
            }

            if (condition != null)
            {
                returnedProducts = returnedProducts.Where(condition).ToList();
            }

            return returnedProducts;
        }

        public Products Save()
        {
            throw new NotImplementedException();
        }
    }
}
