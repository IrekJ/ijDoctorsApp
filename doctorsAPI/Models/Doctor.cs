using System.Collections.Generic;

namespace DoctorsApp.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int MedicalSchoolId { get; set; }
        public MedicalSchool MedicalSchool { get; set; }
        public ICollection<DoctorLanguage> DoctorLanguages { get; set; }
        public ICollection<DoctorSpecialty> DoctorSpecialties { get; set; } = new List<DoctorSpecialty>();
        public ICollection<PatientRating> PatientRatings { get; set; }  
    }
}