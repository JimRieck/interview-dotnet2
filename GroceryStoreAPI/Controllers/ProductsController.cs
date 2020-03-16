using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroceryStoreAPI.Interfaces;
using GroceryStoreAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace GroceryStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : GroceryStoreController
    {
        public ProductsController(IGroceryStoreService groceryStoreService) : base(groceryStoreService)
        {
        }


        // GET api/products/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            var info = groceryStoreService.Build();
            info.products = info.products.Where(o => o.id == id).ToList();
            return JsonConvert.SerializeObject(info.products);
        }

        // GET api/products
        [HttpGet]
        public ActionResult<string> Get()
        {
            var info = groceryStoreService.Build();
            info.products = info.products.ToList();
            
            return JsonConvert.SerializeObject(info.products);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Products newProduct)
        {
            var info = groceryStoreService.Build();
            newProduct.id = info.products.ToList().OrderBy(p => p.id).LastOrDefault().id + 1;

            info.products.Add(newProduct);

            if (ModelState.IsValid)
            {
                this.groceryStoreService.Save(info);
            }
        }
    }
}