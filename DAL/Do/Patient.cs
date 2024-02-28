using System;
using System.Collections.Generic;

namespace DAL.Do;

public partial class Patient
{
    public int Code { get; set; }

    public string PatientId { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public string Email { get; set; } = null!;

    public DateTime BirthDate { get; set; }

    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
}
