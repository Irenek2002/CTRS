using System.ComponentModel.DataAnnotations;
using System;


namespace SharedLibrary.Models
{
    public class Patient
    {
        public int Id { get; set; }
        [Required]

        public int Number { get; set; }
        [Required]

        public string Name { get; set; } = string.Empty;
        [Required]
        public string Gender { get; set; } = string.Empty;

        public string Diagnosis { get; set; } = string.Empty;

        public string MedicationInstructions { get; set; } = string.Empty;

        public string ExpectedTreatmentTime { get; set; }

        public string Physician { get; set; } = string.Empty;

        public double RecentWeight { get; set; } = 60.0;

        public string MedicalHistory { get; set; } = string.Empty;

        public string Operator { get; set; }
        public DateTime OperationTime { get; set; }
    }

}
