using System;
using System.ComponentModel.DataAnnotations;

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
