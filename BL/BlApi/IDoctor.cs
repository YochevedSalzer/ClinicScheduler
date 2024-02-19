using BL.Bo;
//using DAL.DalImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BlApi;
public interface IDoctor
{
    List<Doctor> GetAll();
    Doctor Get(int id);
    Doctor Add(Doctor doctor);
    Doctor Update(Doctor doctor);
    Doctor Delete(int id);
}
