using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroComercial.Shared.Entities
{
    public class Tienda
    {
        public int IdTienda { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string nombreTienda { get; set; }

        [Required(ErrorMessage = "El campo {1} es requerido")]
        public string categoria { get; set; }

        [Required(ErrorMessage = "El campo {2} es requerido")]
        public string horarioApertura { get; set; }

        public string horarioCierre { get; set; }

    }
}
