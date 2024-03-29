using DAL.Do;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DalApi
{
    public interface IDoctor: IRepo<Doctor>
    {
        public List<Doctor> GetByDoctorType(string dType);
    }
}
