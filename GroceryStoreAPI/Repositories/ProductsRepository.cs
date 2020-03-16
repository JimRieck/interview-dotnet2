using GroceryStoreAPI.Interfaces;
using GroceryStoreAPI.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GroceryStoreAPI.Repositories
{
    public class ProductsRepository : DataRepository<Products>
    {
        public override List<Products> GetAll()
        {
            List<Products> returnedProducts = new List<Products>();

            dynamic products = jsonFileReader.ReadDataFromFile("products");

            foreach (dynamic product in products)
            {
                returnedProducts.Add(new Products { id = product.id, description = product.description, price = product.price });
            }

            return returnedProducts;

        }
    }
}
