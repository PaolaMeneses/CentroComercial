using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroComercial.Shared.Entities
{
	public class Ejemplo
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "El documento es requerido")]
		public int Documento { get; set; } = null;

		[Required(ErrorMessage = "El nombre es requerido")]
		public string FirstName { get; set; } = null;

		[Required(ErrorMessage = "El apellido es requerido")]
		public string LastName { get; set; } = null;

		[Required(ErrorMessage = "El celular es requerido")]
		public string CellPhone { get; set; } = null;

	}
}
