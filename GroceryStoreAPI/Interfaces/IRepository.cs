using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreAPI.Interfaces
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll();

        T GetById();

        T Save();
    }
}
