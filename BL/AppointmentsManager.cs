using AutoMapper;
using BL.BlApi;
using BL.BlImplementation;
using BL.Bo;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL;
public class AppointmentsManager
{
    IDoctorSchedule doctorScheduleRepo { get; set; }
    IAppointment appointmentRepo { get; set; }

    public AppointmentsManager(IDoctorSchedule doctorScheduleRepo, IAppointment appointmentRepo)
    {
        this.doctorScheduleRepo = doctorScheduleRepo;
        this.appointmentRepo = appointmentRepo;
    }


    //פונקציה שמקבלת רופא ויום בשבוע ומחזירה את רשימת התורים שקיימים ביום זה בלי התיחסות לפנוי או לא 
    //הפונקציה לוקחת מטבלת מערכת וממירה את זה לתורים.
    //בטבלת מערכת יש שעת התחלה שעת סיום ומשך התור (בדקות
    public List<DateTime> GetAllAppointmentsByDoctorAndDate(int doctorCode, DateOnly date)
    {
        DoctorSchedule doctorSchedule = doctorScheduleRepo.GetAllByDoctorCode(doctorCode).FirstOrDefault(x => x.DayInTheWeek == date.DayOfWeek);
        List<DateTime> result = new List<DateTime>();
        TimeSpan time = doctorSchedule.StartTime, duration = new TimeSpan(0, doctorSchedule.AppointmentDuration, 0);
        while (time != doctorSchedule.FinishTime - duration)
        {
            result.Add( new DateTime(date.Year,date.Month, date.Day, time.Hours, time.Minutes, time.Seconds));
            time += duration;
        }
        return result;

    }


    //פונקציה שמקלת רופא ותאריך ומחזירה את התורים הפנויים ביום זה.
    public List<DateTime> GetAvailableAppointmentsByDateAndDoctor(DateOnly date, int doctorCode)
    {
        //DayOfWeek dayInTheWeek = date.DayOfWeek;
        List<DateTime> allAppointments = GetAllAppointmentsByDoctorAndDate(doctorCode, date);
        List<Appointment> notAvailableAppointments = appointmentRepo.GetAppointmentsByDoctorCode(doctorCode); 

        List<DateTime> result = new List<DateTime>();
        foreach (DateTime appointment in allAppointments)
        {
            if (notAvailableAppointments.FirstOrDefault(x => x.AppointmentTime == appointment) == null)
                result.Add(appointment);
        }
        return result;
    }
    //פונקציה שמקבלת רשימת ימים בשבוע ומחזירה את כל התאריכים של ימים אלו לשנה הקרובה.
    public static List<DateOnly> GetDatesForNextYear(List<DayOfWeek> daysOfWeek)
    {
        List<DateOnly> dates = new List<DateOnly>();
        DateOnly startDate = DateOnly.FromDateTime(DateTime.Now);
        DateOnly endDate = startDate.AddYears(1);

        for (DateOnly date = startDate; date < endDate; date = date.AddDays(1))
        {
            if (daysOfWeek.Contains(date.DayOfWeek))
            {
                dates.Add(date);
            }
        }

        return dates;
    }
    //פונקציה שמקבלת רופא ומחזירה את התאריכים שבהם הוא עובד.
    public List<DateOnly> getAllWorkDatesByDoctor(int doctorCode)
    {

        List<BL.Bo.DoctorSchedule> res= doctorScheduleRepo.GetAllByDoctorCode(doctorCode);
        List<DayOfWeek> days = new List<DayOfWeek>();
        foreach (var item in res)
        {
            days.Add(item.DayInTheWeek);
        }
        List<DateOnly> allWorkDates= GetDatesForNextYear(days);
        return allWorkDates;

    }
    // פונקציה שמקסלת רופא ומחזירה רשימת תאריכים שיש בהם תורים פנויים.
    public List<DateOnly> getAllAvailableWorkDatesByDoctor(int doctorCode)
    {
        List<DateOnly> allWorkDates = getAllWorkDatesByDoctor(doctorCode);
        List<DateOnly> allAvailableWorkDates =new List<DateOnly>();

        foreach (DateOnly workDate in allWorkDates)
        {
            if(GetAvailableAppointmentsByDateAndDoctor(workDate, doctorCode) != null)
                allAvailableWorkDates.Add(workDate);
        }

        
        return allAvailableWorkDates;
    }
}