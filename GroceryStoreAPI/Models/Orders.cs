using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreAPI.Models
{
    public class Orders
    {
        public int id { get; set; }

        public DateTime orderdate { get; set; }

        public int customerId { get; set; }

        public List<Items> items { get; set; }
    }
}
