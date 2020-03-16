using GroceryStoreAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GroceryStoreAPI.Controllers
{
    public class GroceryStoreController : Controller
    {
        protected IGroceryStoreService groceryStoreService { get; set; }

        public GroceryStoreController(IGroceryStoreService groceryStoreService)
        {
            this.groceryStoreService = groceryStoreService;
        }
    }
}