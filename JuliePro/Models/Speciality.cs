using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;

namespace JuliePro.Models
{
    public class Speciality
    {

        public int Id { get; set; }

        [NotNull]
        [Length(5,20,ErrorMessage ="Le nom doit être en 5 et 20 charactères")]
        public string Name { get; set; }
    }
}
