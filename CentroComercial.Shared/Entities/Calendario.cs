using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroComercial.Shared.Entities
{
    public class Calendario
    {
        [Key]
        public int Id { get; set; }
        //public List<Evento> Eventos { get; set; }
        public DateTime FechaActual { get; set; }
    }
}
