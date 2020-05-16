using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APDB11.Models
{
    public class Patient
    {
        public int IdPatient { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DataType Birthdate { get; set; }
    }
}