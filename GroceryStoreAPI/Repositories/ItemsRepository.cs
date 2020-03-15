using GroceryStoreAPI.Interfaces;
using GroceryStoreAPI.Models;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace GroceryStoreAPI.Repositories
{
    public class ItemsRepository : IItemsRepository
    {
        public List<Items> GetAll(string order)
        {
            List<Items> returnedItems = new List<Items>();

            JToken token = JToken.Parse(order.ToString());

            JArray items = (JArray)token.SelectToken("items");

            if (items != null)
            {
                foreach (dynamic item in items)
                {
                    Items newItem = new Items { ProductId = (int)item.productId.Value, Quantity = (int)item.quantity.Value };
                    returnedItems.Add(newItem);
                }
            }

            return returnedItems;   
        }
    }
}
