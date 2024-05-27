using CTRS.Data;
using Microsoft.EntityFrameworkCore;
using SharedLibrary.Models;
using SharedLibrary.PatientRepositories;

namespace CTRS.Implementations
{
    public class PatientRepository : IPatientRepository
    {
        private readonly AppDbContext appDbContext;
        public PatientRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<Patient> AddPatientAsync(Patient model)
        {
            //if (model is null) return null!;
            //var chk = await appDbContext.Patients.Where(_ => _.PatientId.ToLower().Equals(model.PatientId.ToLower())).FirstOrDefaultAsync();
            //if (chk is not null) return null!;

            var newDataAdded = appDbContext.Patients.Add(model).Entity;
            await appDbContext.SaveChangesAsync();
            return newDataAdded;
        }

        public async Task<Patient> DeletePatientAsync(int PatientId)
        {
            var Patient = await appDbContext.Patients.FirstOrDefaultAsync(_ => _.Id == PatientId);
            if (Patient is null) return null!;
            appDbContext.Patients.Remove(Patient);
            await appDbContext.SaveChangesAsync();
            return Patient;
        }

        public async Task<List<Patient>> GetAllPatientsAsync() => await appDbContext.Patients.ToListAsync();

        public async Task<Patient> GetPatientByIdAsync(int PatientId)
        {
            var Patient = await appDbContext.Patients.FirstOrDefaultAsync(_ => _.Id == PatientId);
            if (Patient is null) return null!;
            return Patient;
        }

        public async Task<Patient> UpdatePatientAsync(Patient model)
        {
            var Patient = await appDbContext.Patients.FirstOrDefaultAsync(_ => _.Id == model.Id);
            if (Patient is null) return null!;
            Patient.Name = model.Name;
            Patient.Gender = model.Gender;
            Patient.ExpectedTreatmentTime = model.ExpectedTreatmentTime;
            Patient.Diagnosis = model.Diagnosis;
            Patient.Physician = model.Physician;
            Patient.RecentWeight = model.RecentWeight;
            Patient.MedicalHistory = model.MedicalHistory;
            Patient.MedicationInstructions = model.MedicationInstructions;
            Patient.Operator = model.Operator;
            Patient.OperationTime = model.OperationTime;
            await appDbContext.SaveChangesAsync();
            return await appDbContext.Patients.FirstOrDefaultAsync(_ => _.Id == model.Id)!;
        }
    }
}