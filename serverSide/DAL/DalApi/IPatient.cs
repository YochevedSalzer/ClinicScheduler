﻿using DAL.Do;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DalApi
{
    public interface IPatient: IRepo<Patient>
    {
        public Patient GetByPatientId(string patientId);
    }
}
