using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone2019.Models
{
    public class Composition
    {
        [Key]
        public int Composition_ID { get; set; }
        [Required]
        public int Owner_ID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Tags { get; set; }
        [Required]
        public DateTime Date_Created { get; set; }

        public DateTime Last_Saved { get; set; }
    }
}
