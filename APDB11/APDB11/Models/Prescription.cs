using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APDB11.Models
{
    public class Prescription
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPrescription { get; set; }

        [Required] public DataType Date { get; set; }
        [Required] public DataType DueDate { get; set; }
        [Required] public int IdPatient { get; set; }
        [Required] public int IdDoctor { get; set; }
    }
}