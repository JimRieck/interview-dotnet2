using System.Collections.Generic;

namespace GroceryStoreAPI.Interfaces
{
    public interface IDataRepository<T>
    {
        string order { get; set; }
        List<T> GetAll();
    }
}
