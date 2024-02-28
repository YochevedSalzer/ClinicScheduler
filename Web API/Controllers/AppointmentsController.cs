using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentsController : ControllerBase
    {
        [HttpGet("DoctorCode")]
        public IActionResult GetAll()
        {
            if (doctor.GetAll() != null)
            {
                return Ok(doctor.GetAll());
            }
            return BadRequest();
        }
    }
}
