﻿using System.ComponentModel.DataAnnotations;
 using System.ComponentModel.DataAnnotations.Schema;

 namespace APDB11.Models
{
    public class Medicament
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdMedicament { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Type { get; set; }
    }
}