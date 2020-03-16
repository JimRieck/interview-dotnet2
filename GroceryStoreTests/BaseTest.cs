using GroceryStoreAPI;
using GroceryStoreAPI.Models;
using System.Collections.Generic;

namespace Tests
{
    public class BaseTest
    {
        public List<Customers> GetCustomers()
        {
            List<Customers> expectedCustomers = new List<Customers>();
            expectedCustomers.Add(new Customers { id = 1, name = "Bob" });
            expectedCustomers.Add(new Customers { id = 2, name = "Mary" });
            expectedCustomers.Add(new Customers { id = 3, name = "Joe" });

            return expectedCustomers;
        }

        public List<Products> GetProducts()
        {
            List<Products> expectedProducts = new List<Products>();
            expectedProducts.Add(new Products { id = 1, description = "apple", price = .5 });
            expectedProducts.Add(new Products { id = 2, description = "orange",price = .75 });
            expectedProducts.Add(new Products { id = 3, description = "bananna", price = .85 });

            return expectedProducts;
        }

        public List<Orders> GetOrders()
        {
            List<Orders> expectedOrders = new List<Orders>();
            expectedOrders.Add(new Orders { id = 1, customerId = 1 });
            return expectedOrders;
        }

        public List<Items> GetItems()
        {
            List<Items> items = new List<Items>();
            items.Add(new Items { productId = 1, quantity = 2 });
            items.Add(new Items { productId = 2, quantity = 3 });
            return items;
        }
    }
}