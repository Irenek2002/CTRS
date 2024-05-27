
using SharedLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace SharedLibrary.PatientRepositories
{
    public interface IPatientRepository
    {
        Task<Patient> AddPatientAsync(Patient model);
        Task<Patient> UpdatePatientAsync(Patient model);
        Task<Patient> DeletePatientAsync(int patientId);
        Task<List<Patient>> GetAllPatientsAsync();
        Task<Patient> GetPatientByIdAsync(int patientId);
    }
}