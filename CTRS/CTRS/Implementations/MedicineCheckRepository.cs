using CTRS.Data;
using Microsoft.EntityFrameworkCore;
using SharedLibrary.Models;
using SharedLibrary.MedicineCheckRepositories;

namespace CTRS.Implementations
{
    public class MedicineCheckRepository : IMedicineCheckRepository
    {
        private readonly AppDbContext appDbContext;
        public MedicineCheckRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public async Task<MedicineCheck> AddMedicineCheckAsync(MedicineCheck model)
        {
            //if (model is null) return null!;
           // var chk = await appDbContext.MedicineChecks.Where(_ => _.MedicineName.ToLower().Equals(model.MedicineName.ToLower())).FirstOrDefaultAsync();
            //if (chk is not null) return null!;

            var newDataAdded = appDbContext.MedicineChecks.Add(model).Entity;
            await appDbContext.SaveChangesAsync();
            return newDataAdded;
        }

        public async Task<MedicineCheck> DeleteMedicineCheckAsync(int medicineCheckId)
        {
            var medicineCheck = await appDbContext.MedicineChecks.FirstOrDefaultAsync(_ => _.Id == medicineCheckId);
            if (medicineCheck is null) return null!;
            appDbContext.MedicineChecks.Remove(medicineCheck);
            await appDbContext.SaveChangesAsync();
            return medicineCheck;
        }
        public async Task<List<MedicineCheck>> GetAllMedicineCheckAsync() => await appDbContext.MedicineChecks.ToListAsync();

        public async Task<MedicineCheck> GetMedicineCheckByIdAsync(int medicineCheckId)
        {
            var medicineCheck = await appDbContext.MedicineChecks.FirstOrDefaultAsync(_ => _.Id == medicineCheckId);
            if (medicineCheck is null) return null!;
            return medicineCheck;
        }

        public async Task<MedicineCheck> UpdateMedicineCheckAsync(MedicineCheck model)
        {
            var medicineCheck = await appDbContext.MedicineChecks.FirstOrDefaultAsync(_ => _.Id == model.Id);
            if (medicineCheck is null) return null!;
            medicineCheck.MedicineName = model.MedicineName;
            medicineCheck.Instruction = model.Instruction;
            medicineCheck.EachDosage = model.EachDosage;
            medicineCheck.UnitOfEachDosage = model.UnitOfEachDosage;
            medicineCheck.DidOrDidntTakeMedicine = model.DidOrDidntTakeMedicine;
            medicineCheck.SymptomDescription = model.SymptomDescription;
            medicineCheck.Operator = model.Operator;
            medicineCheck.OperationTime = model.OperationTime;
            await appDbContext.SaveChangesAsync();
            return await appDbContext.MedicineChecks.FirstOrDefaultAsync(_ => _.Id == model.Id);
        }
    }
}