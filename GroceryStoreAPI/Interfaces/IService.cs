using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreAPI.Interfaces
{
    public interface IService<T>
    {
        IEnumerable<T> GetAll();

        T GetById();

        T Save();
    }
}
