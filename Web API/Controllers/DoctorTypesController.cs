using BL;
using BL.BlApi;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorTypesController : ControllerBase
    {
        IType doctorType;
        public DoctorTypesController(BLManager bL)
        {
            this.doctorType = bL.DoctorTypes;  // קבלתי פה אוביקט מטיפוס רפו
        }
        [HttpGet]
        public IActionResult GetAll()
        {

            
            if (doctorType.GetAll() != null)
            {
                return Ok(doctorType.GetAll());
            }
            return BadRequest();
        }

    }
}
