using System.Threading.Tasks;
using doctorsAPI.Data;
using DoctorsApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace doctorsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class DoctorsController : ControllerBase
    {
        //private readonly DataContext _dbContext;
        private readonly IDoctorsRepository _repo;
        public DoctorsController(IDoctorsRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetDoctors()
        {
            var doctors = await _repo.GetDoctors();
            return Ok(doctors);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDoctor(int id)
        {
            var doctor = await _repo.GetDoctor(id);
            return Ok(doctor);
            
        }


    }
}