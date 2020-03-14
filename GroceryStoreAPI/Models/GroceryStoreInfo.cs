using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreAPI.Models
{
    public class GroceryStoreInfo
    {
        public List<Customers> Customers { get; set; }

        public List<Orders> Orders { get; set; }

        public List<Products> Products { get; set; }
    }
}
