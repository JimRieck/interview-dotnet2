using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreAPI.Interfaces
{
    public interface IDataRepository<T>
    {
        List<T> GetAll();

        T GetById(int id);

        T Save(T model);
    }
}
