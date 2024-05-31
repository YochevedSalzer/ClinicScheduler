using AutoMapper;
using BL.BlApi;
using BL.Bo;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BlImplementation
{
    public class DoctorScheduleRepo :IDoctorSchedule
    {

        DAL.DalApi.IDoctorsSchedule DoctorScheduleInstance;
        IMapper map;
        public DoctorScheduleRepo(DalManager Instance, IMapper map)
        {
            this.DoctorScheduleInstance = Instance.DoctorsSchedule;
            this.map = map;
        }

        public List<Bo.DoctorSchedule> GetAll()
        {
            List<DAL.Do.DoctorsSchedule> allDoctorsSchedule = DoctorScheduleInstance.GetAll();
            List<Bo.DoctorSchedule> BoallDoctorsSchedule = new List<Bo.DoctorSchedule>();
            allDoctorsSchedule.ForEach(d => BoallDoctorsSchedule.Add(map.Map<Bo.DoctorSchedule>(d)));
            return BoallDoctorsSchedule;
        }
        public List<Bo.DoctorSchedule> GetAllByDoctorCode(int code)
        {
            List<Bo.DoctorSchedule> BoallDoctorsSchedule = this.GetAll();
            return  BoallDoctorsSchedule.FindAll(x=>x.DoctorCode==code);

        }

        public Bo.Doctor Get(int id)
        {
            return map.Map<Bo.Doctor>(id);
        }
        public Bo.Doctor Add(Bo.Doctor doctor)
        {
            throw new NotImplementedException();
        }

        public Bo.Doctor Delete(int id)
        {
            throw new NotImplementedException();
        }
        public Bo.Doctor Update(Bo.Doctor doctor)
        {
            throw new NotImplementedException();
        }

        DoctorSchedule IRepo<DoctorSchedule>.Get(int id)
        {
            throw new NotImplementedException();
        }

        public DoctorSchedule Add(DoctorSchedule obj)
        {
            throw new NotImplementedException();
        }

        public DoctorSchedule Update(DoctorSchedule obj)
        {
            throw new NotImplementedException();
        }

        DoctorSchedule IRepo<DoctorSchedule>.Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
