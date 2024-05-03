using BL.BlApi;
using BL.BlImplementation;
using DAL;
using DAL.DalApi;
using DAL.Do;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{

    // לבצע הזרקות של שכבת הביאל

    // ליצג את שכבת הביאל
    public class BLManager
    {
        public BL.BlApi.IDoctor Doctors { get; }// = new DoctorRepo(); // אמור לתת שרות שנותנת שכבת הביאל לישות דוקטור
        public BL.BlApi.IPatient Patients { get; }
        public BL.BlApi.IAppointment Appointments { get; }
        public IType DoctorTypes { get; }


        public BLManager(string connStr)
        {

            ServiceCollection services = new ServiceCollection(); // אוסף של מחלקות שרות
            services.AddAutoMapper(typeof(AutoMapper.AutoMapperProfile));
            services.AddSingleton<DalManager>(x=> new DalManager(connStr));
            services.AddScoped <BL.BlApi.IDoctor , DoctorRepo>(); // כאן יצרנו אוביקט יחיד מטיפוס מחלקת שרות של רופאים
            services.AddScoped<BL.BlApi.IPatient, BL.BlImplementation.PatientRepo >();
            services.AddScoped<BL.BlApi.IAppointment, BL.BlImplementation.AppointmentRepo>();
            services.AddScoped<BL.BlApi.IType, BL.BlImplementation.TypeRepo>();

            ServiceProvider provider = services.BuildServiceProvider();  // מנהל את האוסף, כאשר משהו מבקש אוביקט הוא אחראי לתת

            Doctors = provider.GetRequiredService<BL.BlApi.IDoctor>(); // new DoctorRepo();
            Patients = provider.GetRequiredService<BL.BlApi.IPatient>();
            Appointments = provider.GetRequiredService<BL.BlApi.IAppointment>();
            DoctorTypes = provider.GetRequiredService<IType>();
        }
    }
}
