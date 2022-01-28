using System.ComponentModel.DataAnnotations;

namespace comp4945_asn3.Models
{
    public class Customer : Entity
    {
        [Required]
        [StringLength(1024)]
        public string Name { get; set; }
        
    }
}
