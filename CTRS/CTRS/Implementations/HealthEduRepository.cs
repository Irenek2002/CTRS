using Microsoft.EntityFrameworkCore;
using SharedLibrary.Models;
using SharedLibrary.HealthEduRepositories;
using CTRS.Data;

namespace CTRS.Implementations
{
    public class HealthEduRepository : IHealthEduRepository
    {
        private readonly AppDbContext appDbContext;
        public HealthEduRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public async Task<HealthEdu> AddHealthEduAsync(HealthEdu model)
        {
            if (model is null) return null!;
            var chk = await appDbContext.HealthEdu.Where(_ => _.Class.ToLower().Equals(model.Class.ToLower())).FirstOrDefaultAsync();
            if (chk is not null) return null!;

            var newDataAdded = appDbContext.HealthEdu.Add(model).Entity;
            await appDbContext.SaveChangesAsync();
            return newDataAdded;
        }

        public async Task<HealthEdu> DeleteHealthEduAsync(int healthEduId)
        {
            var healthEdu = await appDbContext.HealthEdu.FirstOrDefaultAsync(_ => _.Id == healthEduId);
            if (healthEdu is null) return null!;
            appDbContext.HealthEdu.Remove(healthEdu);
            await appDbContext.SaveChangesAsync();
            return healthEdu;
        }

        public async Task<List<HealthEdu>> GetAllHealthEdusAsync() => await appDbContext.HealthEdu.ToListAsync();

        public async Task<HealthEdu> GetHealthEduByIdAsync(int healthEduId)
        {
            var healthEdu = await appDbContext.HealthEdu.FirstOrDefaultAsync(_ => _.Id == healthEduId);
            if (healthEdu is null) return null!;
            return healthEdu;
        }

        public async Task<HealthEdu> UpdateHealthEduAsync(HealthEdu model)
        {
            var healthEdu = await appDbContext.HealthEdu.FirstOrDefaultAsync(_ => _.Id == model.Id);
            if (healthEdu is null) return null!;
            healthEdu.Title = model.Title;
            healthEdu.Link = model.Link;
            healthEdu.Class = model.Class;

            await appDbContext.SaveChangesAsync();
            return await appDbContext.HealthEdu.FirstOrDefaultAsync(_ => _.Id == model.Id);
        }

        public async Task<List<HealthEdu>> GetHealthEduByClassAsync(string healthClass)
        {
            return await appDbContext.HealthEdu.Where(h => h.Class == healthClass).ToListAsync();
        }
    }
}