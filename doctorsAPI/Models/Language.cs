using System.Collections.Generic;

namespace DoctorsApp.Models
{
    public class Language
    {
        public int Id { get; set; }
        public string Name { get; set; }
         public ICollection<DoctorLanguage> DoctorLanguages { get; set; } 
    }
}