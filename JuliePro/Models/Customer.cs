using System.ComponentModel.DataAnnotations;

namespace JuliePro.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [Required]
        [Length(4,25)]
        public string FirstName { get; set; }

        [Required]
        [Length(4, 25)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Range(100,400)]
        public double StartWeight { get; set; }

        public List<Objective> Objectives { get; set; } = new List<Objective>();
    }
}
