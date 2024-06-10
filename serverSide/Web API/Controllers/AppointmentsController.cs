using BL;
using BL.BlApi;
using BL.Bo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentsController : ControllerBase
    {
        //[HttpGet("DoctorCode")]
        //public IActionResult GetAll()
        //{
        //    if (doctor.GetAll() != null)
        //    {
        //        return Ok(doctor.GetAll());
        //    }
        //    return BadRequest();
        //}
        IAppointment appointment;
        public AppointmentsController(BLManager bLManager)
        {
            appointment = bLManager.Appointments;
        }
        [HttpGet("code")]//האם השם כאן משנה?
        public IActionResult GetByCode(int code) 
        {
            if(appointment.Get(code)!= null)
                return Ok(appointment.Get(code));
            return BadRequest();
        }
        [HttpGet("id")]
        public IActionResult GetAppointmentsByPatientId(string id)
        {
            if(appointment.GetAppointmentsByPatientId(id)!=null)
                return Ok(appointment.GetAppointmentsByPatientId(id));
            return BadRequest();
        }

        [HttpPost]
        public Appointment Post(Appointment appoint)
        {
            appointment.Add(appoint);
            return appoint;
        } 
    }
}
