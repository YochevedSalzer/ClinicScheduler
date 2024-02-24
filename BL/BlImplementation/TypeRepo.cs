using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.BlApi;
using BL.Bo;
using DAL.DalApi;
namespace BL.BlImplementation
{
    public class TypeRepo : IType
    {
        DAL.DalImplementation.DoctorTypeRepo TypeInstance { get; set;}

        public TypeRepo(DAL.DalImplementation.DoctorTypeRepo typeInstance)
        {
            TypeInstance = typeInstance;
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
            for (int i = 0; i < allTypes.Count(); i++)
            {
                BoallTypes.Add(new Bo.DoctorType(allTypes[i].Type));
            }
            return BoallTypes;
        }

        public Bo.DoctorType Update(Bo.DoctorType doctorType)
        {
            throw new NotImplementedException();
        }
    }
}
