using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concierto.Logic.Models
{
    [Table("Users")]
    public class User : IdentityUser
    {
        [MinLength(4, ErrorMessage = "EL nombre debe tener como minimo 4 caracteres")]
        [MaxLength(15, ErrorMessage = "EL nombre debe tener como maximo 15 caracteres")]
        public string Nombre { get; set; } = string.Empty;
        [MinLength(4, ErrorMessage = "EL apellido debe tener como minimo 4 caracteres")]
        [MaxLength(15, ErrorMessage = "EL apellido debe tener como maximo 15 caracteres")]
        public string Apellido { get; set; } = string.Empty;

        public ICollection<Boleto>? Boletos { get; set; }

    }
}
