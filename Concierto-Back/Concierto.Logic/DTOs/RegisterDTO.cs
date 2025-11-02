using Concierto.Logic.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concierto.Logic.DTOs
{
    public class RegisterDTO
    {
        [NotNull]
        public string Nombre { get; set; } = string.Empty;
        [NotNull]
        public string Apellido { get; set; } = string.Empty;
        [NotNull]
        public string UserName { get; set; } = string.Empty;
        [NotNull, DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;
        [NotNull]
        public string Role { get; set; } = string.Empty;

    }
}
