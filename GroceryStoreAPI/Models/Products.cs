using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreAPI.Models
{
    public class Products 
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string description { get; set; }

        [Range(0.0, Double.MaxValue)]
        public double price { get; set; }

       
    }
}
