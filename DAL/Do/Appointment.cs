using System;
using System.Collections.Generic;

namespace DAL.Do;

public partial class Appointment
{
    public int Code { get; set; }

    public int DoctorCode { get; set; }

    public DateTime AppointmentTime { get; set; }

    public int PatientCode { get; set; }

    public virtual Doctor DoctorCodeNavigation { get; set; } = null!;

    public virtual Patient PatientCodeNavigation { get; set; } = null!;
}
