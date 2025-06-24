using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Routing.Constraints;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JuliePro.Models
{
    public class Objective
    {
        public int ObjectiveId { get; set; }

        [Required]
        [Length(5,15)]
        public string Name { get; set; }

        [Range(2,10)]
        public double LostWeightKg { get; set; }

        [Range(2,45)]
        public double DistanceKm { get; set; }
        public DateTime? AchievedDate { get; set; }

        [ValidateNever]
        public Customer Customer { get; set; }


        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
    }
}
