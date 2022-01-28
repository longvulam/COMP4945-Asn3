using System;
using System.ComponentModel.DataAnnotations;

namespace comp4945_asn3.Models
{
    public class Rental : Entity
    {

        public DateTime ReturnDate { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public Book Book { get; set; }

        public Customer Customer { get; set; }

    }
}
