using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoctorsApp.Data;
using DoctorsApp.Models;
using Microsoft.EntityFrameworkCore;

namespace doctorsAPI.Data
{
    public class DoctorsRepository : IDoctorsRepository
    {
        private DataContext _context;
        public DoctorsRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<DoctorDetail> GetDoctor(int id)
        {
            DoctorDetail docDetail = await _context.Doctors.Where(x => x.Id == id).Select(x => new DoctorDetail
            {
                Id = x.Id,
                Name = x.Name,
                Gender = x.Gender,
                MedicalSchool = x.MedicalSchool.Name,
                Languages = x.DoctorLanguages.Select(l => l.Language.Name),
                Specialties = x.DoctorSpecialties.Select(s => s.Specialty.Name),
                PatientRatings = x.PatientRatings,
                Average = x.PatientRatings.Select(r => r.Rating).Average()
            }).SingleOrDefaultAsync();
            return docDetail;
        }

        public async Task<IEnumerable<DoctorSummary>> GetDoctors()
        {
            return await _context.Doctors.Select(x => new DoctorSummary
            {
                Id = x.Id,
                Name = x.Name,
                Gender = x.Gender,
                Specialties = x.DoctorSpecialties.Select(s => s.Specialty.Name),
                Average = x.PatientRatings.Select(r => r.Rating).Average()
            }
            ).ToListAsync(); 

        }

    }
}