using System.Collections.Generic;

namespace DoctorsApp.Models
{
    public class DoctorSummary
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public IEnumerable<string> Specialties { get; set; }
        public double Average { get; set; }
    }
}


