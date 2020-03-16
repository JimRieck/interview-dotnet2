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
    public class OrdersController : Controller
    {
        IGroceryStoreService groceryStoreService { get; set; }

        public OrdersController(IGroceryStoreService groceryStoreService)
        {
            this.groceryStoreService = groceryStoreService;
        }

        // GET api/orders/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            var info = groceryStoreService.Build();
            info.Orders = info.Orders.Where(o => o.Id == id).ToList();
            return JsonConvert.SerializeObject(info.Orders);
        }

        // GET api/orders
        [HttpGet]
        public ActionResult<string> Get()
        {
            var info = groceryStoreService.Build();
            info.Orders = info.Orders.ToList();
            
            return JsonConvert.SerializeObject(info.Orders);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
            var info = groceryStoreService.Build();

        }
    }
}