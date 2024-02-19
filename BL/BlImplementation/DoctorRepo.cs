using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.BlApi;
using DAL;
//using BL.Bo;
//using DAL.Do;
namespace BL.BlImplementation;
public class DoctorRepo : IDoctor
{
    DAL.DalApi.IDoctor DoctorInstance;
    public DoctorRepo(DalManager  Instance)
    {
        this.DoctorInstance = Instance.Doctors ;
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
        throw new NotImplementedException();
    }

    public List<Bo.Doctor> GetAll()
    {
        List<DAL.Do.Doctor> allDoctors = DoctorInstance.GetAll();
        List<Bo.Doctor> BoallDoctors = new List<Bo.Doctor>();
        for (int i = 0; i < allDoctors.Count(); i++)
        {
            BoallDoctors.Add(new Bo.Doctor(allDoctors[i].FirstName, allDoctors[i].LastName, allDoctors[i].PhoneNumber, allDoctors[i].Email, allDoctors[i].DoctorType));
        }
        return BoallDoctors;
    }

    public Bo.Doctor Update(Bo.Doctor doctor)
    {
        throw new NotImplementedException();
    }
}
