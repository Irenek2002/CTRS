using SharedLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SharedLibrary.MedicineCheckRepositories
{
    public interface IMedicineCheckRepository
    {
        Task<MedicineCheck> AddMedicineCheckAsync(MedicineCheck model);
        Task<MedicineCheck> UpdateMedicineCheckAsync(MedicineCheck model);
        Task<MedicineCheck> DeleteMedicineCheckAsync(int medicineCheckId);
        Task<List<MedicineCheck>> GetAllMedicineCheckAsync();
        Task<MedicineCheck> GetMedicineCheckByIdAsync(int medicineCheckId);
    }
}