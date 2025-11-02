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
    [Table("Eventos")]
    public class Evento
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [NotNull]
        [Length(2, 20, ErrorMessage = "El nombre del Cantante debe tener entre 2 y 20 caracteres")]
        public string? Nombre { get; set; }
        [NotNull]
        public DateOnly Fecha { get; set; }
        [NotNull]
        public TimeOnly HoraInicio { get; set; }
        [NotNull]
        public TimeOnly HoraFin { get; set; }
        [NotNull]
        public int IdLugar { get; set; }
        public Lugar? Lugar { get; set; }

        public ICollection<EventoCantante>? EventoCantantes { get; set; }
        public ICollection<Boleto>? Boletos { get; set; }


    }
}
