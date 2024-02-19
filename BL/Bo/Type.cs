using System;
using System.Collections.Generic;

namespace BL.Bo;

public partial class Type
{
    public Type(string DoctorType)
    {
        this.DoctorType = DoctorType; 
    }
    //public int Id { get; set; }

    public string DoctorType { get; set; } = null!;

    //public virtual ICollection<Doctor> Doctors { get; set; } = new List<Doctor>();
}
