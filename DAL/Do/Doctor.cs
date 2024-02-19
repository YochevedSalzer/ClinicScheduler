using System;
using System.Collections.Generic;

namespace DAL.Do;

public partial class Doctor
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public int PhoneNumber { get; set; }

    public string Email { get; set; } = null!;

    public int DoctorType { get; set; }

    public virtual Type DoctorTypeNavigation { get; set; } = null!;
}
