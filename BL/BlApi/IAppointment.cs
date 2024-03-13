using BL.Bo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BlApi
{
    public interface IAppointment:IRepo<Appointment>
    {
       public List<Appointment> GetAppointmentsByPatientId(string patientId);
    }
}
