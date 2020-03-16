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
            info.orders = info.orders.Where(o => o.id == id).ToList();
            return JsonConvert.SerializeObject(info.orders);
        }

        // GET api/orders/5
        [HttpGet("orderbydate/{date}")]
        public ActionResult<string> Get(DateTime date)
        {
            var info = groceryStoreService.Build();
            info.orders = info.orders.Where(o => o.orderdate == date).ToList();
            return JsonConvert.SerializeObject(info.orders);
        }

        // GET api/orders
        [HttpGet]
        public ActionResult<string> Get()
        {
            var info = groceryStoreService.Build();
            info.orders = info.orders.ToList();
            
            return JsonConvert.SerializeObject(info.orders);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
            var info = groceryStoreService.Build();

        }
    }
}