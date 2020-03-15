using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreAPI.Interfaces
{
    public interface ICustomerRepository
    {
        List<Customers> GetAll();

        Customers GetById(int id);

        Customers Save(Customers model);
    }
}
