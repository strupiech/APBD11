using System.ComponentModel.DataAnnotations;

namespace APDB11.DTOs
{
    public class ModifyDoctorRequest
    {
        [Required] public int IdDoctor { get; set; }
        [Required] public string FirstName { get; set; }
        [Required] public string LastName { get; set; }

        public string? Email { get; set; }
    }
}