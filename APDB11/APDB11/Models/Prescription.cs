using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APDB11.Models
{
    public class Prescription
    {
        public int IdPrescription { get; set; }

        public DataType Date { get; set; }
        public DataType DueDate { get; set; }
        public int IdPatient { get; set; }
        public int IdDoctor { get; set; }
    }
}