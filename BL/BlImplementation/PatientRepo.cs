using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BL.BlApi;
using BL.Bo;
using DAL;
using DAL.Do;

namespace BL.BlImplementation;

public class PatientRepo : IPatient
{
    DAL.DalApi.IPatient Patient { get; set; }
    IMapper map;
    public PatientRepo(DalManager dalManager, IMapper map)
    {
        Patient = dalManager.Patients;
        this.map = map;
    }

    public List<Bo.Patient> GetAll()
    {
        List<DAL.Do.Patient> allPatients = Patient.GetAll();
        List<Bo.Patient> BoallPatients = new List<Bo.Patient>();
        allPatients.ForEach(p => BoallPatients.Add(map.Map<Bo.Patient>(p)));
        return BoallPatients;
       
    }

    public Bo.Patient Get(int code)
    {
        DAL.Do.Patient  patient = Patient.Get(code);
        return map.Map<Bo.Patient>(patient);
    }
    public Bo.Patient Add(Bo.Patient patient)
    {
        throw new NotImplementedException();
    }

    public Bo.Patient Update(Bo.Patient patient)
    {
        throw new NotImplementedException();
    }


    public Bo.Patient GetByPatientId(string patientId, string email)
    {
        DAL.Do.Patient patient = Patient.GetByPatientId(patientId);
        if(patient.Email == email)
        {
            return map.Map<Bo.Patient>(patient);
        }
        return null;
    }

   

    public Bo.Patient Delete(int id)
    {
        throw new NotImplementedException();
    }
}
