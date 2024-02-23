using DAL.DalApi;
using DAL.Do;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DalImplementation
{
    public class TypeRepo :IDoctorType
    {
        ClinicContext Context { get; set; }
        public TypeRepo(ClinicContext context)
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

        public Do.Type Get(int id)
        {
            return Context.Types.Find(id);
        }

        public List<Do.Type> GetAll()
        {
            List<Do.Type> result = Context.Types.ToList();
            return result;
        }

        public Do.Type Update(Do.Type obj)
        {
            throw new NotImplementedException();
        }

        public Do.Type Delete(int id)
        {
            Do.Type type = Get(id);
            Context.Types.Remove(type);
            Context.SaveChanges();
            return type;
        }
    }
}
