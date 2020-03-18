using System.Collections.Generic;

namespace GroceryStoreAPI.Models
{
    public class GroceryStoreInfo
    {
        public List<Customers> customers { get; set; }

        public List<Orders> orders { get; set; }

        public List<Products> products { get; set; }
    }
}
