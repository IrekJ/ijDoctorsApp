using System.Collections.Generic;

namespace DoctorsApp.Models
{
    public class DoctorDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string MedicalSchool { get; set; }
        public IEnumerable<string> Languages { get; set; }
        public IEnumerable<string> Specialties { get; set; }
        public IEnumerable<PatientRating> PatientRatings { get; set; }
        public double Average { get; set; } 
    }
}