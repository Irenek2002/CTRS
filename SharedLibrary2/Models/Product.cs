using System;
using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public int Number { get; set; }
        public DateTime? AssessmentDate { get; set; } = DateTime.MinValue;
        public double? Height { get; set; }
        public double? Weight { get; set; }
        public string Consciousness { get; set; }
        public int? BP { get; set; }
        public int? HR { get; set; }
        public int? RR { get; set; }
        public double? BT { get; set; }
        public string PhysicalCondition { get; set; }
        public string Abroad { get; set; }
        public string Occupation { get; set; }
        public string AllergyHistory { get; set; }
        public string MedicalHistory { get; set; }
        public string SideEffects { get; set; }
        public string Operator { get; set; }
        public DateTime? OperationTime { get; set; }


    }
}