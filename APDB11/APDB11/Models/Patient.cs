using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APDB11.Models
{
    public class Patient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPatient { get; set; }

        [Required] public string FirstName { get; set; }
        [Required] public string LastName { get; set; }

        public DataType Birthdate { get; set; }
    }
}