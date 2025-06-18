using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JuliePro.Models
{
    public class Trainer
    {

        public int Id { get; set; }

        [Required]
        [Length(4, 25, ErrorMessage = "Le prénom doit être entre 4 et 25 Charactères")]
        public string FirstName { get; set; }

        [Required]
        [Length(4, 25, ErrorMessage = "Le prénom doit être entre 4 et 25 Charactères")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [MaxLength(40, ErrorMessage ="Maximum de 40 charactères")]
        public string Photo { get; set; }

        [ValidateNever]
        public Speciality speciality { get; set; }

        [ForeignKey("Speciality")]
        public int SpecialityId { get; set; }
    }
}
