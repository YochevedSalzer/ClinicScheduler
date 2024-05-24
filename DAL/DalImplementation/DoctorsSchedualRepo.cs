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
        public DoctorsSchedule Get(int doctorCode)
        {

            return Context.DoctorsSchedules.FirstOrDefault(x => x.DoctorCode == doctorCode);
        }
        public List<DoctorsSchedule> GetAll()
        {
            return Context.DoctorsSchedules.ToList();
        }
        public DoctorsSchedule Add(DoctorsSchedule obj)
        {
            throw new NotImplementedException();
        }

        public DoctorsSchedule Delete(int id)
        {
            throw new NotImplementedException();
        }

      

        public DoctorsSchedule Update(DoctorsSchedule obj)
        {
            throw new NotImplementedException();
        }
    }
}
