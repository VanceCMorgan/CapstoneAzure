using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone2019.Models
{
    public class Favourite
    {
        [Key]
        public int Favourite_ID { get; set; }
        [Required]
        public int Record_ID { get; set; }
        [Required]
        public int Owner_ID { get; set; }
    }
}
