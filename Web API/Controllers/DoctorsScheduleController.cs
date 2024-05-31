using BL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web_API.Controllers;


    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsScheduleController : ControllerBase
    {
        private AppointmentsManager appointmentsManager;

        public DoctorsScheduleController(BLManager bLManager)
        {
           appointmentsManager = bLManager.AppointmentsManager;
        }

        // GET: api/DoctorsSchedule/{doctorId}/available-dates
        [HttpGet("{doctorCode}/available-dates")]
        public  IActionResult GetAllAvailableDatesByDoctor(int doctorCode)
        {
            //try
            //{
                var availableDates =  appointmentsManager.getAllAvailableWorkDatesByDoctor(doctorCode);
                if (availableDates == null || !availableDates.Any())
                {
                    return NotFound("No available dates found for the specified doctor.");
                }

                return Ok(availableDates);
            //}
            //catch (Exception ex)
            //{
            //    return StatusCode(500, $"Internal server error: {ex.Message}");
            //}
        }

        // GET: api/DoctorsSchedule/{doctorId}/available-appointments/{date}
        [HttpGet("{doctorCode}/available-appointments/{date}")]
        public IActionResult GetAllAvailableAppointmentsByDateAndDoctor(int doctorCode, DateOnly date)
        {
            try
            {
                var availableAppointments =  appointmentsManager.GetAvailableAppointmentsByDateAndDoctor(date, doctorCode);
                if (availableAppointments == null || !availableAppointments.Any())
                {
                    return NotFound("No available appointments found for the specified date.");
                }

                return Ok(availableAppointments);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }

   

   

