using System;
using System.Collections.Generic;

namespace DAL.Do;

public partial class Type
{
    public int Id { get; set; }

    public string Type1 { get; set; } = null!;

    public virtual ICollection<Doctor> Doctors { get; set; } = new List<Doctor>();
}
