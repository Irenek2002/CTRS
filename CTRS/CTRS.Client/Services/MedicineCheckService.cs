using SharedLibrary.Models;
using SharedLibrary.MedicineCheckRepositories;
using System.Net.Http.Json;
namespace CTRS.Client.Services
    {
        public class MedicineCheckService : IMedicineCheckRepository
    {
            private readonly HttpClient httpClient;
            public MedicineCheckService(HttpClient httpClient)
            {
                this.httpClient = httpClient;
            }
            public async Task<MedicineCheck> AddMedicineCheckAsync(MedicineCheck model)
            {
                var medicineCheck = await httpClient.PostAsJsonAsync("api/MedicineCheck/Add-MedicineCheck", model);
                var response = await medicineCheck.Content.ReadFromJsonAsync<MedicineCheck>();
                return response!;
            }

            public async Task<MedicineCheck> DeleteMedicineCheckAsync(int medicineCheckId)
            {
                var medicineCheck = await httpClient.DeleteAsync($"api/MedicineCheck/Delete-MedicineCheck/{medicineCheckId}");
                var response = await medicineCheck.Content.ReadFromJsonAsync<MedicineCheck>();
                return response!;
            }

            async Task<List<MedicineCheck>> IMedicineCheckRepository.GetAllMedicineCheckAsync()
            {
                var medicineChecks = await httpClient.GetAsync("api/MedicineCheck/All-MedicineChecks");
                var response = await medicineChecks.Content.ReadFromJsonAsync<List<MedicineCheck>>();
                return response!;
            }

            public async Task<MedicineCheck> GetMedicineCheckByIdAsync(int medicineCheckId)
            {
                var medicineCheck = await httpClient.GetAsync($"api/MedicineCheck/Single-MedicineCheck/{medicineCheckId}");
                var response = await medicineCheck.Content.ReadFromJsonAsync<MedicineCheck>();
                return response!;
            }

            public async Task<MedicineCheck> UpdateMedicineCheckAsync(MedicineCheck model)
            {
                var medicineCheck = await httpClient.PutAsJsonAsync("api/MedicineCheck/Update-MedicineCheck", model);
                var response = await medicineCheck.Content.ReadFromJsonAsync<MedicineCheck>();
                return response!;
            }

        public Task<List<MedicineCheck>> GetAllMedicineCheckAsync()
        {
            throw new NotImplementedException();
        }
    }
    }