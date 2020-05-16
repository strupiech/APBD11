using System.Threading.Tasks;
using APDB11.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace APDB11.Services
{
    public interface IDbService
    {
        public Task<IActionResult> GetDoctors();
        public Task<IActionResult> EnrollDoctor(EnrollDoctorRequest request);
        public Task<IActionResult> ModifyDoctor(ModifyDoctorRequest request);
        public Task<IActionResult> RemoveDoctor(RemoveDoctorRequest request);

    }
}