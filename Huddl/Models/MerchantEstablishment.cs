using System.ComponentModel.DataAnnotations;

namespace Huddl.Models
{
    public class MerchantEstablishment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Establishment { get; set; }

        [Required]
        public string Address { get; set; }

        public string Team { get; set; }
    }

}

