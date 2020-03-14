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
    public class ItemsRepository : BaseRepository, IRepository<Items>
    {
        public List<Items> Get(Func<Items, bool> condition = null)
        {
            List<Items> returnedItems = new List<Items>();
            
            //dynamic items = ReadDataFromFile("orders items");
            var myJsonString = File.ReadAllText("database.json");
            JObject rss = JObject.Parse(myJsonString);

            JToken token = JToken.Parse(myJsonString);
            JArray items = (JArray)token.SelectToken("orders[0].items");
            //foreach (dynamic item in orders)
            //{
            //    returnedCustomers.Add(new Items { ProductId = item.productid, Quantity = item.quantity });
            //}

            //if (condition != null)
            //{
            //    returnedCustomers = returnedCustomers.Where(condition).ToList();
            //}

            return returnedItems;
        }  

        public Items Save()
        {
            throw new NotImplementedException();
        }
    }
}
