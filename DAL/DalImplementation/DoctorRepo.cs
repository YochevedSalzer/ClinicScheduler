using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DalApi;
using DAL.Do;
namespace DAL.DalImplementation
{
    public class DoctorRepo : IDoctor
    {
        ClinicContext Context;
        public DoctorRepo(ClinicContext context)
        {
            Context = context;
        }
        public Doctor Add(Doctor doctor)
        {
            if (Context.Doctors.Find(doctor) != null)
            {
                Context.Doctors.Add(doctor);
                Context.SaveChanges();
                return doctor;
            }
            return null;
        }

        public Doctor Get(int id)
        {
            return Context.Doctors.Find(id);
        }

        public List<Doctor> GetAll()
        {
            List<Doctor> result = Context.Doctors.ToList();
            return result;
        }

        public Doctor Update(Doctor obj)
        {
            throw new NotImplementedException();
        }

        public Doctor Delete(int id)
        {
            Doctor doctor = Get(id);
            Context.Doctors.Remove(doctor);
            Context.SaveChanges();
            return doctor;
        }
    }
}
