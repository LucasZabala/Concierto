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
    [Table("Cantantes")]
    public class Cantante
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [NotNull]
        [Length(2,20, ErrorMessage = "El nombre del Cantante debe tener entre 2 y 20 caracteres")]
        public string? Nombre { get; set; }

        public ICollection<EventoCantante>? EventosCantante { get; set; }
        
    }
}
