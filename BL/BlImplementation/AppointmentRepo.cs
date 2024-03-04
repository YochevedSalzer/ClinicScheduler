using BL.BlApi;
using DAL;
using DAL.Do;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BlImplementation
{
    internal class AppointmentRepo : IAppointment
    {

        DAL.DalApi.IAppointment AppointmentInstance;
        public AppointmentRepo(DalManager Instance)
        {
            this.AppointmentInstance = Instance.Appointments;
        }
        public Appointment Add(Appointment doctor)
        {
            throw new NotImplementedException();
        }

        public Appointment Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Appointment Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Appointment> GetAll()
        {
            throw new NotImplementedException();
        }

        public Appointment Update(Appointment doctor)
        {
            throw new NotImplementedException();
        }
    }
}
