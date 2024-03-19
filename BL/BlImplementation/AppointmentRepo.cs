using BL.BlApi;
using DAL;
using DAL.Do;
using BL.Bo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace BL.BlImplementation
{
    internal class AppointmentRepo : IAppointment
    {

        DAL.DalApi.IAppointment AppointmentInstance;
        IMapper map;
        public AppointmentRepo(DalManager Instance, IMapper map)
        {
            this.AppointmentInstance = Instance.Appointments;
            this.map = map;
        }
        public List<Bo.Appointment> GetAll()
        {
            List<DAL.Do.Appointment> allAppointments = AppointmentInstance.GetAll();
            
            List<Bo.Appointment> BoallAppointments = new List<Bo.Appointment>();
            allAppointments.ForEach
                (a => BoallAppointments.Add(map.Map<Bo.Appointment>(a)));
            return BoallAppointments;
        }

        public Bo.Appointment Get(int id)
        {
            throw new NotImplementedException();
        }


        public List<Bo.Appointment> GetAppointmentsByPatientId(string patientId="1")
        {
            return new List<Bo.Appointment>();
                AppointmentInstance.GetAppointmentsByPatientId(patientId).ToList();
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
