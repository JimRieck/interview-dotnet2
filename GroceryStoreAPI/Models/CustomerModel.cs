using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreAPI
{
    public class Customers
    {
        [Required]
        public int id { get; set; }

        [Required]
        public String name {get; set;}


    }
}
