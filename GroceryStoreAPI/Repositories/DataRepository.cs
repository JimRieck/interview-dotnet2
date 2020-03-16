using GroceryStoreAPI.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Collections.Generic;
using System;

namespace GroceryStoreAPI.Repositories
{
    public  class DataRepository<T> : IDataRepository<T> where T : class
    {
        public string order { get; set ; }

        public virtual List<T> GetAll()
        {
            throw new NotImplementedException();
        }
       

       

       
    }
}
