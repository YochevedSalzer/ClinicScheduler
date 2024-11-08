﻿using BL.BlApi;
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
    public class AppointmentRepo : IAppointment
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

        public Bo.Appointment Get(int code)
        {
            return map.Map<Bo.Appointment>( AppointmentInstance.Get(code));
        }


        public List<Bo.Appointment> GetAppointmentsByPatientId(string patientId="1")
        {
            return map.Map<List<Bo.Appointment>>( AppointmentInstance.GetAppointmentsByPatientId(patientId).ToList());
        }
        public List<Bo.Appointment> GetAppointmentsByDoctorCode(int code)
        {
            return map.Map<List<Bo.Appointment>>(AppointmentInstance.GetAppointmentsByDoctorCode(code).ToList());
        }
        public Bo.Appointment Add(Bo.Appointment appointment)
        {
            AppointmentInstance.Add(map.Map<DAL.Do.Appointment>(appointment));
            return appointment;
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
