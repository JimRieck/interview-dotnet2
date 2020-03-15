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
            expectedProducts.Add(new Products { Id = 1, Description = "apple", Price = .5 });
            expectedProducts.Add(new Products { Id = 2, Description = "orange", Price = .75 });
            expectedProducts.Add(new Products { Id = 3, Description = "bananna", Price = .85 });

            return expectedProducts;
        }

        public List<Orders> GetOrders()
        {
            List<Orders> expectedOrders = new List<Orders>();
            expectedOrders.Add(new Orders { Id = 1, CustomerId = 1 });
            return expectedOrders;
        }
    }
}