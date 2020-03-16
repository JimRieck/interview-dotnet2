using GroceryStoreAPI.Models;

namespace GroceryStoreAPI.Interfaces
{
    public interface IGroceryStoreRepository
    {
        GroceryStoreInfo Build();

        void Save(GroceryStoreInfo storeInfo);
    }
}
