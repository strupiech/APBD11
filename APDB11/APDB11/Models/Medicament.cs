﻿﻿using System.ComponentModel.DataAnnotations;
 using System.ComponentModel.DataAnnotations.Schema;

 namespace APDB11.Models
{
    public class Medicament
    {
        public int IdMedicament { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
    }
}