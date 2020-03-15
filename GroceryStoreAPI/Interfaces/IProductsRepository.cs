using GroceryStoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreAPI.Interfaces
{
    public interface IProductsRepository
    {
        List<Products> GetAll();

        Products GetById(int id);

        Products Save(Products model);
    }
}
