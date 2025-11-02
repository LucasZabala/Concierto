using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concierto.Logic.Models
{
    public class EventoCantante
    {
        public int IdEvento { get; set; }
        public int IdCantante { get; set; }
        public Evento? Evento { get; set; }
        public Cantante? Cantante {  get; set; }
    }
}
