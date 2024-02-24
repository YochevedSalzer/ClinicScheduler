using DAL.DalApi;
using DAL.Do;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DalImplementation
{
    public class DoctorTypeRepo :IDoctorType
    {
        ClinicContext Context { get; set; }
        public DoctorTypeRepo(ClinicContext context)
        {
            Context = context;
        }
        public Do.DoctorType Add(Do.DoctorType type)
        {
            if (Context.DoctorTypes.Find(type) != null)
            {
                Context.DoctorTypes.Add(type);
                Context.SaveChanges();
                return type;
            }
            return null;
        }

        public Do.DoctorType Get(int id)
        {
            return Context.DoctorTypes.Find(id);
        }

        public List<Do.DoctorType> GetAll()
        {
            List<Do.DoctorType> result = Context.DoctorTypes.ToList();
            return result;
        }

        public Do.DoctorType Delete(int id)
        {
            Do.DoctorType type = Get(id);
            Context.DoctorTypes.Remove(type);
            Context.SaveChanges();
            return type;
        }

        public DoctorType Update(DoctorType obj)
        {
            throw new NotImplementedException();
        }
    }
}
