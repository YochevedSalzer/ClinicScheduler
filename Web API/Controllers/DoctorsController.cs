using BL;
using BL.BlApi;
using BL.BlImplementation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        IDoctor doctor;
        public DoctorsController (BLManager  bL)
        {
            this.doctor = bL.Doctors;  // קבלתי פה אוביקט מטיפוס רפו
        }
        [HttpGet]
      public  IActionResult GetAll()
        {
            if (doctor.GetAll()!=null)
            {
                return Ok(doctor.GetAll());
            }
            return BadRequest();
        }

    }
}
