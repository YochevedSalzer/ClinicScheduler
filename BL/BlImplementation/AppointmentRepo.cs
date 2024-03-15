using BL.BlApi;
using DAL;
using DAL.Do;
using BL.Bo;
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
        public List<Bo.Appointment> GetAll()
        {
            List<DAL.Do.Appointment> allAppointments = AppointmentInstance.GetAll();
            List<Bo.Appointment> BoallAppointments = new List<Bo.Appointment>();
            ////List<DAL.Do.Doctor> allDoctors=

            //for (int i = 0; i < allAppointments.Count(); i++)
            //{
            //    BoallAppointments.Add(new Bo.Appointment(allAppointments[i].DoctorCode));
            //}
            return BoallAppointments;
        }

        public Bo.Appointment Get(int id)
        {
            throw new NotImplementedException();
        }


        public List<Bo.Appointment> GetAppointmentsByPatientId(string patientId)
        {
            throw new NotImplementedException();
        }
        public Bo.Appointment Add(Bo.Appointment obj)
        {
            throw new NotImplementedException();
        }

        public Bo.Appointment Delete(int id)
        {
            throw new NotImplementedException();
        }
        public Bo.Appointment Update(Bo.Appointment obj)
        {
            throw new NotImplementedException();
        }
    }
}
