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
    public class BaseRepository<T> : IDataRepository<T> where T : class
    {
        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public T Save(T model)
        {
            throw new NotImplementedException();
        }

        public dynamic ReadDataFromFile(string tableName)
        {
            var myJsonString = File.ReadAllText("database.json");
            JObject rss = JObject.Parse(myJsonString);

            dynamic jsonObj = JsonConvert.DeserializeObject(myJsonString);
            return jsonObj[tableName];
        }

       
    }
}
