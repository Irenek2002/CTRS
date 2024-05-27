using CTRS.Client.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SharedLibrary.PatientRepositories;
using SharedLibrary.ProductRepositories;
using SharedLibrary.HealthEduRepositories;
using SharedLibrary.MedicineCheckRepositories;
using SharedLibrary.ReservationRepositories;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped<IPatientRepository, PatientService>();
builder.Services.AddScoped<IProductRepository, ProductService>();
builder.Services.AddScoped<IHealthEduRepository, HealthEduService>();
builder.Services.AddScoped<IMedicineCheckRepository, MedicineCheckService>();
builder.Services.AddScoped<IReservationRepository, ReservationService>();

builder.Services.AddScoped(http => new HttpClient
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress),
});
await builder.Build().RunAsync();