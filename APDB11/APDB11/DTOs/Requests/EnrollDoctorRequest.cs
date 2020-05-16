using System.ComponentModel.DataAnnotations;

namespace APDB11.DTOs
{
    public class EnrollDoctorRequest
    {
        [Required] public string FirstName { get; set; }
        [Required] public string LastName { get; set; }

        public string? Email { get; set; }
    }
}