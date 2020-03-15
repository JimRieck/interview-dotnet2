using GroceryStoreAPI.Models;
using System.Collections.Generic;

namespace GroceryStoreAPI.Interfaces
{
    public interface IProductsRepository
    {
        List<Products> GetAll();

        Products GetById(int id);

        Products Save(Products model);
    }
}
