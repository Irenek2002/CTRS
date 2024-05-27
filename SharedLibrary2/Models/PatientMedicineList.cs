using System.Collections.Generic;
using System;

namespace SharedLibrary.Models
{
    public class PatientMedicineList //<!-- 藥物記錄的類別 -->
    {
        public string MedicineName { get; set; }
        public string Dosage { get; set; }
        public string ImageUrl { get; set; }
        public DateTime Time { get; set; }
        public bool ShowReasons { get; set; } // Define the ShowReasons property
        public string Reason { get; set; }
        public List<string> SideEffects { get; set; } // 副作用清單屬性
        public string SelectedReason { get; set; } // 用於儲存使用者選擇的原因
        public string Id { get; set; }

        public int ProductId { get; set; }
        public MedicineCheck Product { get; set; }
    }
}