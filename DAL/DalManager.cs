﻿using DAL.DalApi;
using DAL.DalImplementation;
using DAL.Do;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DalManager
    {
        public IDoctor Doctors { get; set; }
        public IPatient Patients { get; set; }
        public DalManager()
        {
            ServiceCollection services=new ServiceCollection();

            services.AddSingleton<ClinicContext>();
            services.AddScoped<IDoctor, DoctorRepo>();
            services.AddScoped<IPatient, PatientRepo>();    

            ServiceProvider servicesProvider = services.BuildServiceProvider();

            Doctors=servicesProvider.GetRequiredService<IDoctor>();
            Patients = servicesProvider.GetRequiredService<IPatient>();
        }
    }
}
