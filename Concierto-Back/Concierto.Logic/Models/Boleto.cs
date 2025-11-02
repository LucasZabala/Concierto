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
    [Table("Boletos")]
    public class Boleto
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [NotNull]
        public string? Code { get; set; }
        public bool Valido { get; set; } = true;
        [NotNull]
        public int IdEvento {  get; set; }
        public Evento? Evento { get; set; }
        public int IdUser {get; set; }
        public User? User { get; set; }
    }
}
