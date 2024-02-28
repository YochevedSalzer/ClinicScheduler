using DAL.DalApi;
using DAL.Do;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DalImplementation
{
    public class AppointmentRepo : IAppointment
    {
        ClinicContext Context { get; set; }
        public AppointmentRepo(ClinicContext context)
        {
            Context = context;
        }

        public Appointment Get(int id)
        {
            throw new NotImplementedException();
        }
        public Appointment Add(Appointment obj)
        {
            throw new NotImplementedException();
        }

        public Appointment Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Appointment> GetAll()
        {
            throw new NotImplementedException();
        }

        public Appointment Update(Appointment obj)
        {
            throw new NotImplementedException();
        }
    }
}
