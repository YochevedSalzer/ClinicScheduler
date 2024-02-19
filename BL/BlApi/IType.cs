using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Bo;

namespace BL.BlApi
{
    public interface IType
    {
        List<Bo.Type> GetAll();
        Bo.Type Get(int id);
        Bo.Type Add(Bo.Type doctorType);
        Bo.Type Update(Bo.Type doctorType);
        Bo.Type Delete(int id);
    }
}
