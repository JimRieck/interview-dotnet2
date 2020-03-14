using GroceryStoreAPI.Interfaces;
using GroceryStoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreAPI.Services
{
    public class ProductsService : IService<Products>
    {
        IRepository<Products> productsRepository;

        public ProductsService(IRepository<Products> productsRepository)
        {
            this.productsRepository = productsRepository;
        }

        public List<Products> GetAll()
        {
            throw new NotImplementedException();
        }

        public Products GetById(int customerId)
        {
            throw new NotImplementedException();
        }

        public Products Save()
        {
            throw new NotImplementedException();
        }
    }
}
