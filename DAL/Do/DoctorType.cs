using System;
using System.Collections.Generic;

namespace DAL.Do;

public partial class DoctorType
{
    public int Id { get; set; }

    public string Type { get; set; } = null!;

    public virtual ICollection<Doctor> Doctors { get; set; } = new List<Doctor>();
}
