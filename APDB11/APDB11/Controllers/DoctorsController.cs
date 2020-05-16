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
        private readonly IDbService _dbService;
        
        public DoctorsController(IDbService dbService)
        {
            _dbService = dbService;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetDoctor()
        {
            return await _dbService.GetDoctors();
        }
        
        [HttpPost("enroll")]
        public async Task<IActionResult> EnrollDoctor(EnrollDoctorRequest request)
        {
            return await _dbService.EnrollDoctor(request);
        }
        
        [HttpPut("modify")]
        public async Task<IActionResult> ModifyDoctor(ModifyDoctorRequest request)
        {
            return await _dbService.ModifyDoctor(request);
        }
        
        [HttpDelete("remove")]
        public async Task<IActionResult> RemoveDoctor(RemoveDoctorRequest request)
        {
            return await _dbService.RemoveDoctor(request);
        }
    }
}