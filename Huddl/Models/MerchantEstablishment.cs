using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Huddl.Models
{
    public class MerchantEstablishment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string EstablishmentName { get; set; }

        [Required]
        public string EstablishmentAddress { get; set; }

        public string TeamAffiliate { get; set; }
    }

}

