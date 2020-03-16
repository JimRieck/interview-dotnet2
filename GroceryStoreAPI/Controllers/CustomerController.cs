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
    public class CustomerController : Controller
    {
        IGroceryStoreService groceryStoreService { get; set; }

        public CustomerController(IGroceryStoreService groceryStoreService)
        {
            this.groceryStoreService = groceryStoreService;
        }

        // GET api/customer/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            var info = groceryStoreService.Build();
            info.Customers =  info.Customers.Where(c => c.id == id).ToList();
            info.Orders = info.Orders.Where(o => o.CustomerId == id).ToList();
            return JsonConvert.SerializeObject(info);
        }

        // GET api/customer
        [HttpGet]
        public ActionResult<string> Get()
        {
            var info = groceryStoreService.Build();
            info.Customers = info.Customers.ToList();
            
            return JsonConvert.SerializeObject(info.Customers);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
            var info = groceryStoreService.Build();

        }
    }
}