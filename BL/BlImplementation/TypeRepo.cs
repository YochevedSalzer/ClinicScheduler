using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.BlApi;
using BL.Bo;
namespace BL.BlImplementation
{
    public class TypeRepo : IType
    {
        DAL.DalImplementation.TypeRepo TypeInstance { get; set;}

        public TypeRepo(DAL.DalImplementation.TypeRepo typeInstance)
        {
            TypeInstance = typeInstance;
        }

        public Bo.Type Add(Bo.Type doctorType)
        {
            throw new NotImplementedException();
        }

        public Bo.Type Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Bo.Type Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Bo.Type> GetAll()
        {
            List<DAL.Do.Type> allTypes = TypeInstance.GetAll();
            List<Bo.Type> BoallTypes = new List<Bo.Type>();
            for (int i = 0; i < allTypes.Count(); i++)
            {
                BoallTypes.Add(new Bo.Type(allTypes[i].Type1));
            }
            return BoallTypes;
        }

        public Bo.Type Update(Bo.Type doctorType)
        {
            throw new NotImplementedException();
        }
    }
}
