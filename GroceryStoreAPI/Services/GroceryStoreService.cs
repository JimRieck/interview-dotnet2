using GroceryStoreAPI.Interfaces;
using GroceryStoreAPI.Models;
using GroceryStoreAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreAPI.Services
{
    public class GroceryStoreService : BaseService
    {
        IGroceryStoreRepository groceryRepository;

        IGroceryStoreRepository customerRepository;
        IGroceryStoreRepository ordersRepository;
        IGroceryStoreRepository productsRepository;

        public GroceryStoreService(IGroceryStoreRepository groceryRepository, IGroceryStoreRepository customerRepository, IGroceryStoreRepository ordersRepository, IGroceryStoreRepository productsRepository)
        {
            this.groceryRepository = groceryRepository;
        }

        public override GroceryStoreInfo GetAll()
        {
            return this.groceryRepository.GetAll();
        }

        public GroceryStoreInfo GetById(int id)
        {
            return this.groceryRepository.GetById(id);
        }

        public GroceryStoreInfo Save(GroceryStoreInfo storeInfo)
        {
            return this.groceryRepository.Save(storeInfo);
        }
    }
}
