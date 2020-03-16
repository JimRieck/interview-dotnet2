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
        ICustomerRepository customerRepository;
        IOrdersRepository ordersRepository;
        IProductsRepository productsRepository;
        

        public GroceryStoreService(ICustomerRepository customerRepository,
            IOrdersRepository ordersRepository, 
            IProductsRepository productsRepository)
        {
           
            this.customerRepository = customerRepository;
            this.ordersRepository = ordersRepository;
            this.productsRepository = productsRepository;
        }

        public GroceryStoreInfo Build()
        {
            GroceryStoreInfo info = new GroceryStoreInfo();
            info.customers = customerRepository.GetAll();
            info.orders = ordersRepository.GetAll();
            info.products = productsRepository.GetAll();

           

            return info;
        }

        public List<GroceryStoreInfo> GetByCustomerId(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(GroceryStoreInfo storeInfo)
        {
            string jsonFile = JsonConvert.SerializeObject(storeInfo);
            using (StreamWriter file = File.CreateText(@"database.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, storeInfo);
            }
           
        }

      
    }
}
