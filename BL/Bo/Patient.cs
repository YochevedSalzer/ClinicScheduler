using System;
using System.Collections.Generic;

namespace BL.Bo;

public partial class Patient
{
    //public int Id { get; set; }
    public Patient(string PatientId, string FirstName, string LastName, string PhoneNumber, string Email, DateTime BirthDate, List<DAL.Do.Appointment> appointments)
    {
        this.PatientId = PatientId;
        this.FirstName = FirstName;
        this.LastName = LastName;
        this.PhoneNumber = PhoneNumber;
        this.Email = Email;
        this.BirthDate = DateOnly.FromDateTime(BirthDate);
        Age = DateTime.Now.Year - BirthDate.Year;
        Appointments = appointments;
    }
    
    public string PatientId { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string PhoneNumber { get; set; }

    public string Email { get; set; } = null!;

    public DateOnly BirthDate { get; set; }
    public int Age { get; set; }
    public List<DAL.Do.Appointment> Appointments { get; set; }
}
