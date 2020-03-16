using System.Collections.Generic;

namespace GroceryStoreAPI.Interfaces
{
    public interface ICustomerRepository
    {
        List<Customers> GetAll();
    }
}
