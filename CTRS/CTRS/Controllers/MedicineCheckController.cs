using Microsoft.AspNetCore.Mvc;
using SharedLibrary.Models;
using SharedLibrary.MedicineCheckRepositories;
using CTRS.Implementations;
namespace CTRS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicineCheckController : ControllerBase
    {
        private readonly IMedicineCheckRepository medicineCheckRepository;
        public MedicineCheckController(IMedicineCheckRepository medicineCheckRepository)
        {
            this.medicineCheckRepository = medicineCheckRepository;
        }

        [HttpGet("All-MedicineChecks")]
        public async Task<ActionResult<List<MedicineCheck>>> GetAllMedicineCheckAsync()
        {
            var medicineChecks = await medicineCheckRepository.GetAllMedicineCheckAsync();
            return Ok(medicineChecks);
        }

        [HttpGet("Single-MedicineCheck/{id}")]
        public async Task<ActionResult<List<MedicineCheck>>> GetSingleMedicineCheckAsync(int id)
        {
            var medicineCheck = await medicineCheckRepository.GetMedicineCheckByIdAsync(id);
            return Ok(medicineCheck);
        }

        [HttpPost("Add-MedicineCheck")]
        public async Task<ActionResult<List<MedicineCheck>>> AddMedicineCheckAsync(MedicineCheck model)
        {
            var medicineCheck = await medicineCheckRepository.AddMedicineCheckAsync(model);
            return Ok(medicineCheck);
        }

        [HttpPut("Update-MedicineCheck")]
        public async Task<ActionResult<List<MedicineCheck>>> UpdateMedicineCheckAsync(MedicineCheck model)
        {
            var medicineCheck = await medicineCheckRepository.UpdateMedicineCheckAsync(model);
            return Ok(medicineCheck);
        }

        [HttpDelete("Delete-MedicineCheck/{id}")]
        public async Task<ActionResult<List<MedicineCheck>>> DeleteMedicineCheckAsync(int id)
        {
            var medicineCheck = await medicineCheckRepository.DeleteMedicineCheckAsync(id);
            return Ok(medicineCheck);
        }

    }
}