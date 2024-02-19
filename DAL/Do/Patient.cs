using System;
using System.Collections.Generic;

namespace DAL.Do;

public partial class Patient
{
    public int Id { get; set; }

    public string PatientId { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public int PhoneNumber { get; set; }

    public string Email { get; set; } = null!;

    public DateTime BirthDate { get; set; }
}
