using BL.BlApi;
using BL.BlImplementation;
using DAL;
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
        public IDoctor Doctors { get; }// = new DoctorRepo(); // אמור לתת שרות שנותנת שכבת הביאל לישות דוקטור
        public IPatient Patients { get; }

        public BLManager()
        {

            ServiceCollection services = new ServiceCollection(); // אוסף של מחלקות שרות

            services.AddSingleton<DalManager>();
            services.AddScoped <IDoctor , DoctorRepo>(); // כאן יצרנו אוביקט יחיד מטיפוס מחלקת שרות של רופאים
            services.AddScoped<IPatient, PatientRepo >();


            ServiceProvider provider = services.BuildServiceProvider();  // מנהל את האוסף, כאשר משהו מבקש אוביקט הוא אחראי לתת

            Doctors = provider.GetRequiredService<IDoctor>(); // new DoctorRepo();
            //Patients = provider.GetRequiredService<IPatient>();


        }
    }
}
