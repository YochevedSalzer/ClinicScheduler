﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DalApi;
using DAL.Do;

namespace DAL.DalImplementation
{
    public class PatientRepo : IPatient

    {
        ClinicContext Context;
        public PatientRepo(ClinicContext context)
        {
            Context = context;
        }

        public List<Patient> GetAll()
        {
            List<Patient> result = Context.Patients.ToList();
            return result;
        }
        public Patient GetByPatientId(string patientId)
        {
            return Context.Patients.FirstOrDefault(p => p.PatientId == patientId);
        }
        public Patient Get(int code)
        {
            return Context.Patients.FirstOrDefault(p => p.Code == code);
        }
        public Patient Add(Patient patient)
        {
            if (Context.Patients.Find(patient) != null)
            {
                Context.Patients.Add(patient);
                Context.SaveChanges();
                return patient;
            }
            return null;
        }

        public Patient Delete(int id)
        {
           Patient patient = Get(id);
            if (patient != null)
            {
                Context.Patients.Remove(patient);
                Context.SaveChanges();  
            }
            return patient;
        }
        public Patient Update(Patient obj)
        {
            throw new NotImplementedException();
        }

       
    }
}
