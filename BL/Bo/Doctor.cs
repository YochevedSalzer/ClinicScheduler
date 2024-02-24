using Azure;
using System;
using System.Collections.Generic;
using DAL.Do;

namespace BL.Bo;

public class Doctor
{
    DAL.DalImplementation.DoctorTypeRepo dtype;
    //public int Id { get; set; }
    public Doctor(string FirstName, string LastName, int PhoneNumber, string Email, int IntDoctorType)
    {

        this.FirstName = FirstName;
        this.LastName = LastName;
        this.PhoneNumber = PhoneNumber;
        this.Email = Email;
        //DoctorType = DAL.Do.Type.Type1 where DAL.Do.Type.Id.Equals(DoctorType);
        DoctorType = dtype.GetAll().FirstOrDefault(i=>i.Id== IntDoctorType).Type;


    }
    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public int PhoneNumber { get; set; }

    public string Email { get; set; } = null!;
    public string DoctorType { get; set; }

    //public int DoctorType { get; set; }

    //public virtual Type DoctorTypeNavigation { get; set; } = null!;
}
