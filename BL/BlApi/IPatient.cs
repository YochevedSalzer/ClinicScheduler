using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Bo;
namespace BL.BlApi;
public interface IPatient : IRepo<Patient>
{
    public Patient GetByPatientId(string patientId);
}
