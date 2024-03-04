using DAL.DalApi;
using DAL.Do;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DalImplementation
{
    public class AppointmentRepo : IAppointment
    {
        ClinicContext Context { get; set; }
        public AppointmentRepo(ClinicContext context)
        {
            Context = context;
        }

        public Appointment Get(int id)
        {
            return Context.Appointments.Find();
        }
        //public List<Appointment> GetAllPatientsAppointments(int patientId)
        //{
        //    return Context.Appointments.Select
        public Appointment Add(Appointment obj)
        {
            if (Context.Appointments.FirstOrDefault(a=>a.DoctorCode == obj.DoctorCode && a.AppointmentTime==obj.AppointmentTime) == null)
            {
                Context.Appointments.Add(obj);
                Context.SaveChanges();
                return obj;
            }
            return null;
        }

        public Appointment Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Appointment> GetAll()
        {
            throw new NotImplementedException();
        }

        public Appointment Update(Appointment obj)
        {
            throw new NotImplementedException();
        }
    }
}
