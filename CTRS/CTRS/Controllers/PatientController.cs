using CTRS.Implementations;
using Microsoft.AspNetCore.Mvc;
using SharedLibrary.Models;
using SharedLibrary.PatientRepositories;
namespace CTRS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatientRepository patientRepository;
        public PatientController(IPatientRepository patientRepository)
        {
            this.patientRepository = patientRepository;
        }

        [HttpGet("All-Patients")]
        public async Task<ActionResult<List<Patient>>> GetAllPatientAsync()
        {
            var patients = await patientRepository.GetAllPatientsAsync();
            return Ok(patients);
        }

        [HttpGet("Single-Patient/{id}")]
        public async Task<ActionResult<List<Patient>>> GetSinglePatientAsync(int id)
        {
            var patient = await patientRepository.GetPatientByIdAsync(id);
            return Ok(patient);
        }

        [HttpPost("Add-Patient")]
        public async Task<ActionResult<List<Patient>>> AddPatientAsync(Patient model)
        {
            var patient = await patientRepository.AddPatientAsync(model);
            return Ok(patient);
        }

        [HttpPut("Update-Patient")]
        public async Task<ActionResult<List<Patient>>> UpdatePatientAsync(Patient model)
        {
            var patient = await patientRepository.UpdatePatientAsync(model);
            return Ok(patient);
        }

        [HttpDelete("Delete-Patient/{id}")]
        public async Task<ActionResult<List<Patient>>> DeletePatientAsync(int id)
        {
            var patient = await patientRepository.DeletePatientAsync(id);
            return Ok(patient);
        }
    }
}