using DoctorsApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DoctorsApp.Data
{
     public class DataContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<MedicalSchool> MedicalSchools { get; set; }
        public DbSet<PatientRating> PatientRatings { get; set; }
        public DbSet<Specialty> Specialties { get; set; }
        public DbSet<DoctorLanguage> DoctorLanguages { get; set; }
        public DbSet<DoctorSpecialty> DoctorSpecialties { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options) {}
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DoctorLanguage>()
                .HasKey(dl => new {dl.DoctorId, dl.LanguageId});

            modelBuilder.Entity<DoctorSpecialty>()
                .HasKey(ds => new {ds.DoctorId, ds.SpecialtyId});
        }
    }
}