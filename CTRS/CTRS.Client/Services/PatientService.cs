using SharedLibrary.Models;
using SharedLibrary.PatientRepositories;
using System.Net.Http.Json;
namespace CTRS.Client.Services
{

    public class PatientService : IPatientRepository
    {
        private readonly HttpClient httpClient;
        public PatientService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<Patient> AddPatientAsync(Patient model)
        {
            var Patient = await httpClient.PostAsJsonAsync("api/Patient/Add-Patient", model);
            var response = await Patient.Content.ReadFromJsonAsync<Patient>();
            return response!;
        }


        public async Task<Patient> DeletePatientAsync(int PatientId)
        {
            var Patient = await httpClient.DeleteAsync($"api/Patient/Delete-Patient/{PatientId}");
            var response = await Patient.Content.ReadFromJsonAsync<Patient>();
            return response!;
        }

        public async Task<List<Patient>> GetAllPatientsAsync()
        {
            var Patients = await httpClient.GetAsync("api/Patient/All-Patients");
            var response = await Patients.Content.ReadFromJsonAsync<List<Patient>>();
            return response!;
        }

        public async Task<Patient> GetPatientByIdAsync(int PatientId)
        {
            var Patient = await httpClient.GetAsync($"api/Patient/Single-Patient/{PatientId}");
            var response = await Patient.Content.ReadFromJsonAsync<Patient>();
            return response!;
        }

        public async Task<Patient> UpdatePatientAsync(Patient model)
        {
            var Patient = await httpClient.PutAsJsonAsync("api/Patient/Update-Patient", model);
            var response = await Patient.Content.ReadFromJsonAsync<Patient>();
            return response!;
        }
    }
}