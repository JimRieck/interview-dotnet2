using GroceryStoreAPI.Interfaces;
using GroceryStoreAPI.Models;
using Newtonsoft.Json;
using System.IO;

namespace GroceryStoreAPI
{
    public class GroceryStoreRepository : IGroceryStoreRepository
    {
        ICustomerRepository customerRepository;
        IOrdersRepository ordersRepository;
        IProductsRepository productsRepository;
       


        public GroceryStoreRepository(ICustomerRepository customerRepository,
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