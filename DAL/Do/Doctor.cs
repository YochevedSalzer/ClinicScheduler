using System;
using System.Collections.Generic;

namespace DAL.Do;

public partial class Doctor
{
    public int Code { get; set; }

    public string Id { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public int PhoneNumber { get; set; }

    public string Email { get; set; } = null!;

    public int DoctorType { get; set; }

    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    public virtual DoctorType DoctorTypeNavigation { get; set; } = null!;
}
