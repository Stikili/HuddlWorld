using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Huddl.Models
{
    public class Beverages
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Beverage { get; set; }


    }
}

