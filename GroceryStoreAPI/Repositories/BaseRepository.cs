using GroceryStoreAPI.Interfaces;
using GroceryStoreAPI.Models;
using GroceryStoreAPI.Services;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;

namespace GroceryStoreAPI.Repositories
{
    public abstract class BaseRepository : IGroceryStoreRepository
    {
        public virtual GroceryStoreInfo GetAll()
        {
            throw new NotImplementedException();
        }

        public virtual GroceryStoreInfo GetById(int id)
        {
            throw new NotImplementedException();
        }

        public virtual GroceryStoreInfo Save(GroceryStoreInfo storeInfo)
        {
            throw new NotImplementedException();
        }

        protected dynamic ReadDataFromFile(string tableName)
        {
            var myJsonString = File.ReadAllText("database.json");
            JObject rss = JObject.Parse(myJsonString);



            dynamic jsonObj = JsonConvert.DeserializeObject(myJsonString);
            return jsonObj[tableName];
        }

       
    }
}
