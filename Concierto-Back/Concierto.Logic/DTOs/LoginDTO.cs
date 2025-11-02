using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concierto.Logic.DTOs
{
    public class LoginDTO
    {
        [Required, NotNull]
        public string? UserName {  get; set; }
        [Required, NotNull,DataType(DataType.Password)]
        public string? Password { get; set; }
    }
}
