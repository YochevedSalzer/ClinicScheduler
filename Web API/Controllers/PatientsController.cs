using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BL.BlApi;
using BL;

namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        IPatient patient;
        public PatientsController(BLManager  BLpatient)
        {
            this.patient = BLpatient.Patients ;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            if (patient.GetAll() != null)
            {
                return Ok(patient.GetAll());
            }
            return BadRequest();
        }

        [HttpGet("{patientCode}")]
        public IActionResult Get(int patientCode)
        {
            if(patient.Get(patientCode) != null)
            { return Ok(patient.Get(patientCode));}
            return BadRequest();
        }

        //[HttpGet("patientId")]
        //public IActionResult GetByPatientId(string patientId)
        //{
        //    if (patient.GetByPatientId(patientId,) != null)
        //    { return Ok(patient.GetByPatientId(patientId)); }
        //    return BadRequest();
        //}
    }
}
