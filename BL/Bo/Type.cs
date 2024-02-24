using System;
using System.Collections.Generic;

namespace BL.Bo;

public class DoctorType
{
    public string DType { get; set; } = null!;
    public DoctorType(string DType)
    {
        this.DType = DType; 
    }
    //public int Id { get; set; }

    

    //public virtual ICollection<Doctor> Doctors { get; set; } = new List<Doctor>();
}
