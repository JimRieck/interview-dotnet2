using GroceryStoreAPI.Interfaces;
using GroceryStoreAPI.Models;
using GroceryStoreAPI.Repositories;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace GroceryStoreAPI.Services
{
    public class GroceryStoreService : IGroceryStoreService
    {
        IGroceryStoreRepository groceryStoreRepository;

        public GroceryStoreService(IGroceryStoreRepository groceryStoreRepository)
        {
            this.groceryStoreRepository = groceryStoreRepository;
        }

        public GroceryStoreInfo Build()
        {
            return groceryStoreRepository.Build();
        }

        public void Save(GroceryStoreInfo storeInfo)
        {
            groceryStoreRepository.Save(storeInfo);
           
        }

      
    }
}
