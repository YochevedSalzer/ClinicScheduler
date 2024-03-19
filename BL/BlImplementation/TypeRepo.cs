using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BL.BlApi;
using BL.Bo;
using DAL;
using DAL.DalApi;
namespace BL.BlImplementation
{
    public class TypeRepo : IType
    {
        DAL.DalApi.IDoctorType TypeInstance;
        IMapper map;

        public TypeRepo(DalManager instance, IMapper map)
        {
            TypeInstance = instance.DoctorTypes;
            this.map = map;
        }

        public Bo.DoctorType Add(Bo.DoctorType doctorType)
        {
            throw new NotImplementedException();
        }

        public Bo.DoctorType Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Bo.DoctorType Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Bo.DoctorType> GetAll()
        {
            List<DAL.Do.DoctorType> allTypes = TypeInstance.GetAll();
            List<Bo.DoctorType> BoallTypes = new List<Bo.DoctorType>();
            allTypes.ForEach(t => BoallTypes.Add(map.Map<Bo.DoctorType>(t)));
            return BoallTypes;
        }

        public Bo.DoctorType Update(Bo.DoctorType doctorType)
        {
            throw new NotImplementedException();
        }
    }
}
