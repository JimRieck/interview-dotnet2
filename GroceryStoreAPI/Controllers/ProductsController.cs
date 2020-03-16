using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroceryStoreAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace GroceryStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        IGroceryStoreService groceryStoreService { get; set; }

        public ProductsController(IGroceryStoreService groceryStoreService)
        {
            this.groceryStoreService = groceryStoreService;
        }

        // GET api/products/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            var info = groceryStoreService.Build();
            info.Products = info.Products.Where(o => o.Id == id).ToList();
            return JsonConvert.SerializeObject(info.Products);
        }

        // GET api/products
        [HttpGet]
        public ActionResult<string> Get()
        {
            var info = groceryStoreService.Build();
            info.Products = info.Products.ToList();
            
            return JsonConvert.SerializeObject(info.Products);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
            var info = groceryStoreService.Build();

        }
    }
}