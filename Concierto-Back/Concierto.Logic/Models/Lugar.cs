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
    [Table("Lugares")]
    public class Lugar
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Length(5,50)]
        [NotNull]
        public string? NombreLugar { get; set; }
        [Range(0,5000)]
        [NotNull]
        public int Capacidad { get; set; }

        public ICollection<Evento>? Eventos { get; set; }

    }
}
