using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreAPI.Models
{
    public class Items
    {
        [Required]
        public int productId { get; set; }

        [Required]
        public int quantity { get; set; }
    }
}
