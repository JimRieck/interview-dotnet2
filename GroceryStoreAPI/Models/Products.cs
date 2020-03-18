using System;
using System.ComponentModel.DataAnnotations;

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
