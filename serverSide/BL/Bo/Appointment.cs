using System;
using System.Collections.Generic;

namespace BL.Bo;

public class Appointment
{
    public string DoctorName { get; set; }
    public string DoctorType { get; set; }
    public string PatientName { get; set; }
    public DateTime AppointmentTime { get; set; }
    public int Duration { get; set; }
    //public Appointment(string  doctorName, string DoctorType, string PatientName, DateTime AppointmentTime, int Duration)
    //{
    //    this.DoctorName = doctorName;
    //    this.DoctorType = DoctorType;
    //    this.PatientName = PatientName;
    //    this.AppointmentTime = AppointmentTime;
    //    this.Duration = Duration;
    //}


    //public virtual Doctor DoctorCodeNavigation { get; set; } = null!;

    //public virtual Patient? PatientCodeNavigation { get; set; }
}
