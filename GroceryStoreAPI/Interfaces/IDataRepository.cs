using System.Collections.Generic;

namespace GroceryStoreAPI.Interfaces
{
    public interface IDataRepository<T>
    {
        
        List<T> GetAll();
    }
}
