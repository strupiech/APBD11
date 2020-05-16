using System.Linq;
using System.Threading.Tasks;
using APDB11.DTOs;
using APDB11.Models;
using Microsoft.AspNetCore.Mvc;

namespace APDB11.Services
{
    public class SqlServerHospitalDbService : IDbService
    {
        private readonly HospitalDbContext _context;

        public SqlServerHospitalDbService(HospitalDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> GetDoctors()
        {
            return new OkObjectResult(_context.Doctors.ToList());
        }

        public async Task<IActionResult> EnrollDoctor(EnrollDoctorRequest request)
        {
            var doctor = _context.Doctors.Add(new Doctor()
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email
            });

            await _context.SaveChangesAsync();
            return new CreatedAtActionResult("Enroll Doctor", "DoctorsController", new {id = doctor.Entity.IdDoctor},doctor);
        }

        public async Task<IActionResult> ModifyDoctor(ModifyDoctorRequest request)
        {
            var doctor = _context.Doctors.FirstOrDefault(doc => doc.IdDoctor == request.IdDoctor);

            if (doctor == null) return new BadRequestResult();

            doctor.FirstName = request.FirstName;
            doctor.LastName = request.LastName;
            doctor.Email = request.Email;

            await _context.SaveChangesAsync();
            return new OkObjectResult(doctor);
        }

        public async Task<IActionResult> RemoveDoctor(RemoveDoctorRequest request)
        {
            var doctor = _context.Doctors.FirstOrDefault(doc => doc.IdDoctor == request.IdDoctor);

            if (doctor == null) return new BadRequestResult();

            _context.Remove(doctor);
            await _context.SaveChangesAsync();
            return new AcceptedResult();
        }
    }
}