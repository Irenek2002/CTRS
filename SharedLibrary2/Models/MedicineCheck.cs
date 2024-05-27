using System;
using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.Models
{
    public class MedicineCheck
    {
        public int Id { get; set; }
        [Required]
        public string MedicineName { get; set; } = string.Empty;
        [Required]
        public string Instruction { get; set; } = string.Empty;
        [Required]
        public int EachDosage { get; set; }
        [Required]
        public string UnitOfEachDosage { get; set; }
        public bool DidOrDidntTakeMedicine { get; set; }
        public string SymptomDescription { get; set; }
        [Required]
        public string Operator { get; set; }
        [Required]
        public DateTime OperationTime { get; set; }
    }
}
