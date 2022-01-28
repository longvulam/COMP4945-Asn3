using System.ComponentModel.DataAnnotations;

namespace comp4945_asn3.Models
{
    public class Book : Entity
    {
        [Required]
        [StringLength(1024)]
        public string Title { get; set; }

    }
}
