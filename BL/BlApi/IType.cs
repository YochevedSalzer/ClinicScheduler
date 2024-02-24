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
        List<Bo.DoctorType> GetAll();
        Bo.DoctorType Get(int id);
        Bo.DoctorType Add(Bo.DoctorType doctorType);
        Bo.DoctorType Update(Bo.DoctorType doctorType);
        Bo.DoctorType Delete(int id);
    }
}
