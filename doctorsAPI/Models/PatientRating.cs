namespace DoctorsApp.Models
{
    public class PatientRating
    {
        public int Id { get; set; }
        public int DoctorId { get; set; }
        public string Comments { get; set; }
        public int Rating { get; set; }
    }
}