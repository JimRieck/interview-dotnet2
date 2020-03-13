using GroceryStoreAPI.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreAPI.Repositories
{
    public class CustomerRepository : IRepository<Customers>
    {
        public List<Customers> Get(Func<Customers, bool> condition)
        {
            List<Customers> returnedCustomers = new List<Customers>();

            dynamic jsonObj = ReadDataFromFile("customers");
            var customers = jsonObj.customers; 
            foreach (dynamic item in customers)
            {
                returnedCustomers.Add(new Customers { id = item.id, name = item.name });
            }

            return returnedCustomers.Where(condition).ToList();
        }

        private dynamic ReadDataFromFile(string tableName)
        {
            var myJsonString = File.ReadAllText("database.json");
            JObject rss = JObject.Parse(myJsonString);

            dynamic jsonObj = JsonConvert.DeserializeObject(myJsonString);
            return jsonObj;
        }

        public List<Customers> Get()
        {
            List<Customers> returnedCustomers = new List<Customers>();
            var jsonObj = ReadDataFromFile("customers");
            var customers = jsonObj.customers;
            foreach (dynamic item in customers)
            {
                returnedCustomers.Add(new Customers { id = item.id, name = item.name });
            }

            return returnedCustomers;
        }

        public Customers Save()
        {
            throw new NotImplementedException();
        }

        public List<T> Get<T>()
        {
            throw new NotImplementedException();
        }

      
    }
}
