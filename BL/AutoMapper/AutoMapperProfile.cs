using AutoMapper;
using BL.BlImplementation;
using BL.Bo;
using DAL.DalApi;
using DAL.DalImplementation;
using DAL.Do;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BL.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            ClinicContext context = new ClinicContext();
            DoctorTypeRepo doctorType = new DoctorTypeRepo(context);
            DAL.DalImplementation.DoctorRepo doctorRepo = new DAL.DalImplementation.DoctorRepo(context);
            DAL.DalImplementation.PatientRepo patientRepo = new DAL.DalImplementation.PatientRepo(context);
            CreateMap<BL.Bo.Doctor, DAL.Do.Doctor>().
                ForMember(dest => dest.DoctorType, source => source.MapFrom(src => doctorType.GetAll().Where(d => d.Type== src.DoctorType)));
            CreateMap<DAL.Do.Doctor, BL.Bo.Doctor>()
                .ForMember(dest => dest.DoctorType, source => source.MapFrom(src => src.DoctorTypeNavigation.Type));
            CreateMap<BL.Bo.Patient, DAL.Do.Patient>();
                 //.ForMember(dest => dest., source => source.MapFrom(s => doctorType.GetAll().Where(d => s.DoctorType == d.Type)));
            CreateMap<DAL.Do.Patient, BL.Bo.Patient>()
                .ForMember(dest => dest.Age, source => source.MapFrom(src =>DateTime.Now.Year- src.BirthDate.Year));
            //CreateMap<DAL.Do.DoctorType, BL.Bo.DoctorType>();
            CreateMap<DAL.Do.DoctorType, BL.Bo.DoctorType>().ForMember(dest => dest.DType, source => source.MapFrom(src => src.Type));
            CreateMap<DAL.Do.Appointment, BL.Bo.Appointment>()
                .ForMember(dest => dest.DoctorName, source => source.MapFrom(src => src.DoctorCodeNavigation.FirstName + src.DoctorCodeNavigation.LastName))
                .ForMember(dest => dest.DoctorType, source => source.MapFrom(src => src.DoctorCodeNavigation.DoctorTypeNavigation.Type))
                .ForMember(dest => dest.PatientName, source => source.MapFrom(src => src.PatientCodeNavigation.FirstName + src.PatientCodeNavigation.LastName));
            CreateMap<BL.Bo.Appointment, DAL.Do.Appointment>()
                .ForMember(dest => dest.DoctorCode, source => source.MapFrom(src => doctorRepo.GetAll().Where(d => d.FirstName + d.LastName == src.DoctorName)))
                .ForMember(dest => dest.PatientCode, source => source.MapFrom(src => patientRepo.GetAll().Where(d => d.FirstName + d.LastName == src.PatientName)));



        }
    }
}
