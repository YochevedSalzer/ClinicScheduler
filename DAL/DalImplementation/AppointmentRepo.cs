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
        public List<Appointment> GetAll()
        {
            return Context.Appointments.ToList();
        }
        public Appointment Get(int code)
        {
            return Context.Appointments.Find(code);
        }
        public List<Appointment> GetAppointmentsByPatientId(string patientId)
        {
            int code = Context.Patients.FirstOrDefault(p=>p.PatientId==patientId).Code;

            var result = from appointment in Context.Appointments
                            where (appointment.PatientCode)==code
                            select appointment;
          
            return result.ToList();
        }
        public List<Appointment> GetAllDoctorsAppointments(int doctorId)
        {
            int code = Context.Doctors.Find(doctorId).Code;

            var result = from appointment in Context.Appointments
                         where (appointment.DoctorCode) == code
                         select appointment;

            return result.ToList();
        }
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

        public Appointment Delete(int code)
        {
            var result = Context.Appointments.FirstOrDefault(a => a.Code == code);
            if (result!=null)
            {

                Context.Appointments.Remove(result);
                Context.SaveChanges();
                return result;
            }
            return null;
        }

        public Appointment Update(Appointment obj)
        {
            throw new NotImplementedException();
        }

        
    }
}
