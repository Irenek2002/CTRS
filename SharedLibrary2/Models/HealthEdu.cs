using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.Models
{
    public class HealthEdu
    {
        public int Id { get; set; }
        [Required]
        public string Class { get; set; }
        public string Title { get; set; }
        [Required]
        public string Link { get; set; }



    }
}