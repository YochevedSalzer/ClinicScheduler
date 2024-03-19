using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BL.BlApi;
using DAL;
//using BL.Bo;
//using DAL.Do;
namespace BL.BlImplementation;
public class DoctorRepo : IDoctor
{
    DAL.DalApi.IDoctor DoctorInstance;
    IMapper map;
    public DoctorRepo(DalManager  Instance,IMapper map)
    {
        this.DoctorInstance = Instance.Doctors ;
        this.map = map;
    }

    public Bo.Doctor Add(Bo.Doctor doctor)
    {
        throw new NotImplementedException();
    }

    public Bo.Doctor Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Bo.Doctor Get(int id)
    {
        return map.Map<Bo.Doctor>(id);
    }

    public List<Bo.Doctor> GetAll()
    {
        List<DAL.Do.Doctor> allDoctors = DoctorInstance.GetAll();
        List<Bo.Doctor> BoallDoctors = new List<Bo.Doctor>();
        allDoctors.ForEach(d => BoallDoctors.Add(map.Map<Bo.Doctor>(d)));
        return BoallDoctors;
    }

    public Bo.Doctor Update(Bo.Doctor doctor)
    {
        throw new NotImplementedException();
    }
}
