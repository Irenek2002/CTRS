using SharedLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SharedLibrary.PatientMedicineListRepositories
{
    public interface IPatientMedicineListRepository
    {
        Task<PatientMedicineList> AddPatientMedicineListAsync(PatientMedicineList model);
        Task<PatientMedicineList> UpdatePatientMedicineListAsync(PatientMedicineList model);
        Task<PatientMedicineList> DeletePatientMedicineListAsync(int patientMedicineListId);
        Task<List<PatientMedicineList>> GetAllPatientMedicineListAsync();
        Task<PatientMedicineList> GetPatientMedicineListByIdAsync(int patientMedicineListId);
    }
}