using DAL.Do;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BlApi
{
    public interface IAppointment
    {
        List<Appointment> GetAll();
        Appointment Get(int id);
        Appointment Add(Appointment doctor);
        Appointment Update(Appointment doctor);
        Appointment Delete(int id);
    }
}
