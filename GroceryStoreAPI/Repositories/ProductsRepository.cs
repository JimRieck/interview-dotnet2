﻿using GroceryStoreAPI.Interfaces;
using GroceryStoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GroceryStoreAPI.Repositories
{
    public class ProductsRepository<T> : BaseRepository<T> where T : Products
    {
        public List<Products> GetAll()
        {
            List<Products> returnedProducts = new List<Products>();

            dynamic products = ReadDataFromFile("products");

            foreach (dynamic item in products)
            {
                returnedProducts.Add(new Products { Id = item.id, Description = item.description, Price = item.price });
            }

            return returnedProducts;

        }

        public Products GetById(int id)
        {
            return this.GetAll().FirstOrDefault(p => p.Id == id);


        }

        public Products Save(Products customer)
        {
            return new Products();
        }
    }
}
