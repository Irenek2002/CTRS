using Microsoft.EntityFrameworkCore;
using SharedLibrary.Models;

namespace CTRS.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<HealthEdu> HealthEdu { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<MedicineCheck> MedicineChecks { get; set; }
        public DbSet<PatientMedicineList> PatientMedicineLists { get; set; }


    }
}
