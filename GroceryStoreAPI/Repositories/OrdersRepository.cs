using GroceryStoreAPI.Interfaces;
using GroceryStoreAPI.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GroceryStoreAPI.Repositories
{
    public class OrdersRepository : DataRepository<Orders>
    {
      

        public override List<Orders> GetAll()
        {
            List<Orders> returnedOrders = new List<Orders>();

            dynamic orders = jsonFileReader.ReadDataFromFile("orders");

            foreach (dynamic order in orders)
            {
                Orders newOrder = new Orders { id = order.id, orderdate = order.orderdate == null ? DateTime.Now : order.orderdate , customerId = order.customerId, items = new List<Items>() };

                List<Items> newItems = this.ProcessItemsForOrder(order.ToString());

                newOrder.items.AddRange(newItems);

                returnedOrders.Add(newOrder);
                
            }
            
            return returnedOrders;
        }

        private List<Items> ProcessItemsForOrder(string order)
        {
            List<Items> returnedItems = new List<Items>();

            JToken token = JToken.Parse(order.ToString());

            JArray items = (JArray)token.SelectToken("items");

            if (items != null)
            {
                foreach (dynamic item in items)
                {
                    Items newItem = new Items { productId = (int)item.productId.Value, quantity = (int)item.quantity.Value };
                    returnedItems.Add(newItem);
                }
            }

            return returnedItems;
        }
    }
}
