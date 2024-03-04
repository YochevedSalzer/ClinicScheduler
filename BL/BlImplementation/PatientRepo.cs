using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.BlApi;
using BL.Bo;
using DAL;
using DAL.Do;

namespace BL.BlImplementation;

public class PatientRepo : IPatient
{
    DAL.DalApi.IPatient Patient { get; set; }
    public PatientRepo(DalManager dalManager)
    {
        Patient = dalManager.Patients;
    }

    public List<Bo.Patient> GetAll()
    {
        //List<DAL.Do.Patient> allPatients = Patient.GetAll();
        //List<Bo.Patient> BoallPatients = new List<Bo.Patient>();
        //for (int i = 0; i < allPatients.Count(); i++)
        //{
        //    BoallPatients.Add(new Bo.Patient(allPatients[i].PatientId, allPatients[i].FirstName, allPatients[i].LastName, allPatients[i].PhoneNumber, allPatients[i].Email, allPatients[i].BirthDate));
        //}
        //return BoallPatients;
        throw new NotImplementedException();
    }

    Bo.Patient IPatient.Get(int id)
    {
        ///*return new Bo.Patient(Patient.Get(id).PatientId, Patient.Get(id).FirstName, Patient.Get(id).LastName*/, Patient.Get(id).PhoneNumber, Patient.Get(id).Email, Patient.Get(id).BirthDate);
        throw new NotImplementedException();
    }

    //Bo.Appointment IPatient.GetAppointments(int id)
    //{
    //    return new Bo.Patient(Patient.Get(id).PatientId, Patient.Get(id).FirstName, Patient.Get(id).LastName, Patient.Get(id).PhoneNumber, Patient.Get(id).Email, Patient.Get(id).BirthDate);

    //}
    public Bo.Patient Add(Bo.Patient patient)
    {
        throw new NotImplementedException();
    }

    public Bo.Patient Update(Bo.Patient patient)
    {
        throw new NotImplementedException();
    }

    Bo.Patient IPatient.Delete(int id)
    {
        throw new NotImplementedException();
    }
}
