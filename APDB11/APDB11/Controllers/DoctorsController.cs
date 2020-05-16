using System.Linq;
using System.Threading.Tasks;
using APDB11.DTOs;
using APDB11.Models;
using APDB11.Services;
using Microsoft.AspNetCore.Mvc;

namespace APDB11.Controllers
{
    [Route("api/doctors")]
    [ApiController]
    
    public class DoctorsController : ControllerBase
    {
        private readonly HospitalDbContext _context;
        private readonly IDbService _dbService;
        
        public DoctorsController(IDbService dbService, HospitalDbContext context)
        {
            _dbService = dbService;
            _context = context;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetDoctor()
        {
            return _dbService.GetDoctors();
        }
        
        [HttpPost("add")]
        public async Task<IActionResult> RemoveStudent(EnrollDoctorRequest request)
        {
            return await _dbService.AddDoctor(request);
        }
        
        [HttpPut("modify")]
        public async Task<IActionResult> ModifyStudent(ModifyDoctorRequest request)
        {
            return await _dbService.ModifyDoctor(request);
        }
        
        [HttpPost("remove")]
        public async Task<IActionResult> RemoveStudent(RemoveDoctorRequest request)
        {
            return await _dbService.RemoveDoctor(request);
        }
    }
}