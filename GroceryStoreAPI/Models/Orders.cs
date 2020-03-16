using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreAPI.Models
{
    public class Orders
    {
        [Key]
        public int id { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime orderdate { get; set; }

        [Required]
        public int customerId { get; set; }

        public List<Items> items { get; set; }
    }
}
