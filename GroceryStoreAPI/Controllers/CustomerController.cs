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
    public class CustomerController : GroceryStoreController
    {
        public CustomerController(IGroceryStoreService groceryStoreService) : base(groceryStoreService)
        {
        }
        
        // GET api/customer/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            var info = groceryStoreService.Build();
            info.customers =  info.customers.Where(c => c.id == id).ToList();
            info.orders = info.orders.Where(o => o.customerId == id).ToList();
            return JsonConvert.SerializeObject(info);
        }

        // GET api/customer
        [HttpGet("allcustomerorders")]
        public ActionResult<string> GetCustomerOrders()
        {
            var info = groceryStoreService.Build();
            info.customers = info.customers.ToList();

            return string.Format("{0} {1}", JsonConvert.SerializeObject(info.customers), JsonConvert.SerializeObject(info.orders));
        }


        // GET api/customer
        [HttpGet]
        public ActionResult<string> Get()
        {
            var info = groceryStoreService.Build();
            info.customers = info.customers.ToList();
            
            return JsonConvert.SerializeObject(info.customers);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Customers newCustomer)
        {
            var info = groceryStoreService.Build();
            newCustomer.id = info.customers.ToList().OrderBy(p => p.id).LastOrDefault().id + 1;

            info.customers.Add(newCustomer);

            this.groceryStoreService.Save(info);

        }
    }
}