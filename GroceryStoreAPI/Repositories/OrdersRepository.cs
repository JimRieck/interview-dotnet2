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
    public class OrdersRepository : BaseRepository
    {
        public override GroceryStoreInfo GetAll()
        {
            GroceryStoreInfo info = new GroceryStoreInfo();
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

            //if (condition != null)
            //{
            //    returnedOrders = returnedOrders.Where(condition).ToList();
            //}

            info.Orders = returnedOrders;
            return info;
        }

        public override GroceryStoreInfo GetById(int id)
        {
            GroceryStoreInfo info = new GroceryStoreInfo();
            info = this.GetAll();
            info.Orders = info.Orders.Where(p => p.Id== id).ToList();
            return info;
        }

        public GroceryStoreInfo Save()
        {
            throw new NotImplementedException();
        }
    }
}
