using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Bo;
namespace BL.BlApi;
public interface IPatient
{
    List<Patient> GetAll();
    Patient Get(int id);
    Patient Add(Patient patient);
    Patient Update(Patient patient);
    Patient Delete(int id);
}
