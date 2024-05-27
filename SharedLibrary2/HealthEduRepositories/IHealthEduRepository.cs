using SharedLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SharedLibrary.HealthEduRepositories
{
    public interface IHealthEduRepository
    {
        Task<HealthEdu> AddHealthEduAsync(HealthEdu model);
        Task<HealthEdu> UpdateHealthEduAsync(HealthEdu model);
        Task<HealthEdu> DeleteHealthEduAsync(int healthEduId);
        Task<List<HealthEdu>> GetAllHealthEdusAsync();
        Task<HealthEdu> GetHealthEduByIdAsync(int healthEduId);
        Task<List<HealthEdu>> GetHealthEduByClassAsync(string healthClass);

    }
}