﻿using DAL.Do;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DalApi
{
    public interface IAppointment: IRepo<Appointment>
    {
        public List<Appointment> GetAppointmentsByPatientId(string patientId);
        public List<Appointment> GetAppointmentsByDoctorCode(int  code);
    }
}
