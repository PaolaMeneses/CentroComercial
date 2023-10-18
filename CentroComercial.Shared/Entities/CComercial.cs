using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroComercial.Shared.Entities
{
    public class CComercial

    {
        [Key]
        public int IdCentroComercial { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string nombreCentroComercial { get; set; }

        [Required(ErrorMessage = "El campo {1} es requerido")]
        public string capacidadMaxima { get; set; }

        [Required(ErrorMessage = "El campo {2} es requerido")]
        public string horarioApertura { get; set; }

        [Required(ErrorMessage = "El campo {3} es requerido")]
        public string horarioCierre { get; set; }
        public string tiendas { get; set; }
        public string eventos { get; set; }


    }
}
