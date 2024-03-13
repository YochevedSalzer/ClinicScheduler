using DAL.Do;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Bo;
namespace BL.BlApi
{
    public interface IRepo<T>
    {
        List<T> GetAll();
        T Get(int id);
        T Add(T obj);
        T Update(T obj);
        T Delete(int id);
    }
}
