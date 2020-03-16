﻿using GroceryStoreAPI.Interfaces;
using GroceryStoreAPI.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GroceryStoreAPI.Repositories
{
    public class ProductsRepository : BaseRepository, IProductsRepository
    {
        public List<Products> GetAll()
        {
            List<Products> returnedProducts = new List<Products>();

            dynamic products = ReadDataFromFile("products");

            foreach (dynamic product in products)
            {
                returnedProducts.Add(new Products { id = product.id, description = product.description, price = product.price });
            }

            return returnedProducts;

        }

        public Products GetById(int id)
        {
            return this.GetAll().FirstOrDefault(p => p.id == id);


        }

        public Products Save(Products customer)
        {
            return new Products();
        }
    }
}
