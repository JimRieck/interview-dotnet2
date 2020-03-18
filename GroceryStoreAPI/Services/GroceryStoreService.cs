using GroceryStoreAPI.Interfaces;
using GroceryStoreAPI.Models;


namespace GroceryStoreAPI.Services
{
    public class GroceryStoreService : IGroceryStoreService
    {
        IGroceryStoreRepository groceryStoreRepository;

        public GroceryStoreService(IGroceryStoreRepository groceryStoreRepository)
        {
            this.groceryStoreRepository = groceryStoreRepository;
        }

        public GroceryStoreInfo Build()
        {
            return groceryStoreRepository.Build();
        }

        public void Save(GroceryStoreInfo storeInfo)
        {
            groceryStoreRepository.Save(storeInfo);
           
        }

      
    }
}
