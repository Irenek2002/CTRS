using Microsoft.AspNetCore.Mvc;
using SharedLibrary.HealthEduRepositories;
using SharedLibrary.Models;
namespace CTRS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthEduController : ControllerBase
    {
        private readonly IHealthEduRepository healthEduRepository;
        public HealthEduController(IHealthEduRepository healthEduRepository)
        {
            this.healthEduRepository = healthEduRepository;
        }

        [HttpGet("All-HealthEdus")]
        public async Task<ActionResult<List<HealthEdu>>> GetAllHealthEduAsync()
        {
            var healthEdus = await healthEduRepository.GetAllHealthEdusAsync();
            return Ok(healthEdus);
        }

        [HttpGet("Single-HealthEdu/{id}")]
        public async Task<ActionResult<List<HealthEdu>>> GetSingleHealthEduAsync(int id)
        {
            var healthEdu = await healthEduRepository.GetHealthEduByIdAsync(id);
            return Ok(healthEdu);
        }

        [HttpPost("Add-HealthEdu")]
        public async Task<ActionResult<List<HealthEdu>>> AddHealthEduAsync(HealthEdu model)
        {
            var healthEdu = await healthEduRepository.AddHealthEduAsync(model);
            return Ok(healthEdu);
        }

        [HttpPut("Update-HealthEdu")]
        public async Task<ActionResult<List<HealthEdu>>> UpdateHealthEduAsync(HealthEdu model)
        {
            var healthEdu = await healthEduRepository.UpdateHealthEduAsync(model);
            return Ok(healthEdu);
        }

        [HttpDelete("Delete-HealthEdu/{id}")]
        public async Task<ActionResult<List<HealthEdu>>> DeleteHealthEduAsync(int id)
        {
            var healthEdu = await healthEduRepository.DeleteHealthEduAsync(id);
            return Ok(healthEdu);
        }

        [HttpGet("ByClass/{healthClass}")]
        public async Task<ActionResult<List<HealthEdu>>> GetHealthEduByClassAsync(string healthClass)
        {
            var healthEdu = await healthEduRepository.GetHealthEduByClassAsync(healthClass);
            return Ok(healthEdu);
        }

    }
}