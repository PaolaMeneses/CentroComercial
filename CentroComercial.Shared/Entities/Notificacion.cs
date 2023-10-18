using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroComercial.Shared.Entities
{
    public class Notificacion
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Message { get; set; }

        [Required(ErrorMessage = "El campo {1} es requerido")]
        public DateTime SentDate { get; set; }
    }
}
