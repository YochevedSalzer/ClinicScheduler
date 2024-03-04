using DAL.DalApi;
using DAL.Do;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DalImplementation
{
    internal class DoctorsSchedualRepo : IDoctorsSchedule
    {

        ClinicContext Context;
        public DoctorsSchedualRepo(ClinicContext context)
        {
            Context = context;
        }
        public DoctorsSchedule Add(DoctorsSchedule obj)
        {
            throw new NotImplementedException();
        }

        public DoctorsSchedule Delete(int id)
        {
            throw new NotImplementedException();
        }

        public DoctorsSchedule Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<DoctorsSchedule> GetAll()
        {
            throw new NotImplementedException();
        }

        public DoctorsSchedule Update(DoctorsSchedule obj)
        {
            throw new NotImplementedException();
        }
    }
}
