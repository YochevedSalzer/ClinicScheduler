using BL.Bo;
//using DAL.DalImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BlApi;
public interface IDoctor:IRepo<Doctor>
{
    public List<Doctor> GetByDoctorType(string dType);
}
