using System.ComponentModel.DataAnnotations;

namespace APDB11.DTOs
{
    public class RemoveDoctorRequest
    {
        [Required] public int IdDoctor { get; set; }
    }
}