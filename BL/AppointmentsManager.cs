using BL.BlImplementation;
using BL.Bo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL;
public class AppointmentsManager
{
    DoctorScheduleRepo doctorScheduleRepo { get; set; }
    AppointmentRepo appointmentRepo { get; set; }

    //פונקציה שמקבלת רופא ויום בשבוע ומחזירה את רשימת התורים שקיימים ביום זה בלי התיחסות לפנוי או לא 
    //הפונקציה לוקחת מטבלת מערכת וממירה את זה לתורים.
    //בטבלת מערכת יש שעת התחלה שעת סיום ומשך התור (בדקות
    public List<Appointment> GetAllAppointmentsByDoctorAndDayOfWeek(Doctor doctor, int dayOfWeek)
    {
        DoctorSchedule doctorSchedule = doctorScheduleRepo.GetAllByDoctorCode(doctor.Code).FirstOrDefault(x => x.DayInTheWeek == dayOfWeek);
        List<Appointment> result = new List<Appointment>();
        TimeSpan time = doctorSchedule.StartTime, duration = new TimeSpan(0, doctorSchedule.AppointmentDuration, 0);
        while (time != doctorSchedule.FinishTime - duration)
        {
            result.Add(new Appointment() { DoctorName = doctor.FirstName + doctor.LastName, DoctorType = doctor.DoctorType, PatientName = "", AppointmentTime = new DateTime(0, 0, 0, time.Hours, time.Minutes, time.Seconds), Duration = doctorSchedule.AppointmentDuration });
            time += duration;
        }
        return result;

    }


    //פונקציה שמקלת רופא ותאריך ומחזירה את התורים הפנויים ביום זה.
    public List<Appointment> GetAvailableAppointmentsByDateAndDoctor(DateOnly date, Doctor doctor)
    {
        int dayInTheWeek = (int)date.DayOfWeek;
        List<Appointment> allAppointments = GetAllAppointmentsByDoctorAndDayOfWeek(doctor, dayInTheWeek);
        List<Appointment> notAvailableAppointments = appointmentRepo.GetAppointmentsByDoctorCode(doctor.Code);

        List<Appointment> result = new List<Appointment>();
        foreach (Appointment appointment in allAppointments)
        {
            if (notAvailableAppointments.FirstOrDefault(x => x.AppointmentTime == appointment.AppointmentTime) == null)
                result.Add(appointment);
        }
        return result.ToList();
    }


    public List<DateOnly> getAllWorkDatesByDoctor(Doctor doctor)
    {
    //    DateTime today =DateTime.Now.Date;
    //    DateTime aYearFromToday = today.AddYears(1);
    //    List<DateOnly> result= new List<DateOnly>();    
    //    List<DoctorSchedule> doctorSchedule = doctorScheduleRepo.GetAllByDoctorCode(doctor.Code);

    //    foreach(DoctorSchedule schedule in doctorSchedule)
    //    {
    //         schedule.DayInTheWeek
    //    }
    return null;

    }

    public List<DateOnly> getAllAvailableWorkDatesByDoctor(Doctor doctor)
    {
        List<DateOnly> allWorkDates = getAllWorkDatesByDoctor(doctor);
        List<DateOnly> allAvailableWorkDates =new List<DateOnly>();

        foreach (DateOnly workDate in allWorkDates)
        {
            if(GetAvailableAppointmentsByDateAndDoctor(workDate, doctor) != null)
                allAvailableWorkDates.Add(workDate);
        }
        return allAvailableWorkDates;
    }
}