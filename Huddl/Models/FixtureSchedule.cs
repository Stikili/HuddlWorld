using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Huddl.Models
{
    public class FixtureSchedule
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Fixture { get; set; }

        [Required]
        public string Sport { get; set; }

        [Required]
        public string League { get; set; }

        [Required]
        public DateTime Date { get; set; }

    }
}
