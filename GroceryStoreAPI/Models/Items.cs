using System.ComponentModel.DataAnnotations;

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
