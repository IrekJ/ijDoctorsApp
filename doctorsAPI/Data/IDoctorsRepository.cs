using System.Collections.Generic;
using System.Threading.Tasks;
using DoctorsApp.Models;

namespace doctorsAPI.Data
{
    public interface IDoctorsRepository
    {
        Task<IEnumerable<DoctorSummary>> GetDoctors();
         Task<DoctorDetail> GetDoctor(int id);
    }
}