using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DalApi
{
    public interface IRepo<T>
    {
        List<T> GetAll();
        T Get(int code);
        T Add(T obj);
        T Update(T obj);
        T Delete(int id);
    }
}
