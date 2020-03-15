using GroceryStoreAPI.Interfaces;
using GroceryStoreAPI.Models;
using GroceryStoreAPI.Repositories;
using System;
using System.Collections.Generic;
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
            info.Customers = customerRepository.GetAll();
            info.Orders = ordersRepository.GetAll();
            info.Products = productsRepository.GetAll();

            return info;
        }

        public List<GroceryStoreInfo> GetByCustomerId(int id)
        {
            throw new NotImplementedException();
        }

        public GroceryStoreInfo Save(GroceryStoreInfo storeInfo)
        {
            throw new NotImplementedException();
        }
    }
}
