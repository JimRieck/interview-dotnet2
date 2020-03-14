using GroceryStoreAPI.Interfaces;
using GroceryStoreAPI.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreAPI.Repositories
{
    public class OrdersRepository : BaseRepository, IRepository<Orders>
    {
        public List<Orders> Get(Func<Orders, bool> condition = null)
        {
            List<Orders> returnedOrders = new List<Orders>();

            dynamic orders = ReadDataFromFile("orders");

            int counter = 0;
            foreach (dynamic order in orders)
            {
                Orders newOrder = new Orders { Id = order.id, CustomerId = order.customerId, Items = new List<Items>() };

                JToken token = JToken.Parse(order.ToString());
                JArray items = (JArray)token.SelectToken("items");

                if (items != null)
                {
                    foreach (dynamic item in items)
                    {
                        Items newItem = new Items { ProductId = (int)item.productId.Value, Quantity = (int)item.quantity.Value };
                        newOrder.Items.Add(newItem);
                    }
                }
               
                returnedOrders.Add(newOrder);
                counter++;
            }

            if (condition != null)
            {
                returnedOrders = returnedOrders.Where(condition).ToList();
            }

            return returnedOrders;
        }

        public Orders Save()
        {
            throw new NotImplementedException();
        }
    }
}
