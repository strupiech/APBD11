using System.ComponentModel.DataAnnotations;

namespace APDB11.Models
{
    public class PrescriptionMedicament
    {
        [Key] public int IdPrescription { get; set; }
        [Key] public int IdMedicament { get; set; }
        [Required] public int Dose { get; set; }
        [Required] public string Details { get; set; }
    }
}