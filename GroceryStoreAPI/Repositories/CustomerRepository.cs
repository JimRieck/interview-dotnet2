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
        public List<Customers> GetAll()
        {
            List<Customers> returnedCustomers = new List<Customers>();

            var myJsonString = File.ReadAllText("database.json");
           
            var myJsonObject = JsonConvert.DeserializeObject<Customers>(myJsonString);
            dynamic jsonObj = JsonConvert.DeserializeObject(myJsonString);
            foreach (var item in jsonObj.customers)
            {
                returnedCustomers.Add(new Customers { id = item.id, name = item.name });
            }

            return returnedCustomers;
        }

        public Customers GetById()
        {
            throw new NotImplementedException();
        }

        public Customers Save()
        {
            throw new NotImplementedException();
        }
    }
}
