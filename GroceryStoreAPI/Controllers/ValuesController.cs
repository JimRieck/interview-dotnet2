using System.Collections.Generic;
using GroceryStoreAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace GroceryStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : GroceryStoreController
    {
        public ValuesController(IGroceryStoreService groceryStoreService) : base(groceryStoreService)
        {
        }


        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var info = groceryStoreService.Build();
            string jsonString = JsonConvert.SerializeObject(info);
           
            return new string[] { jsonString };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }
    }
}
