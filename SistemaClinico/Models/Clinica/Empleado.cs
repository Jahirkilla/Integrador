using System.ComponentModel.DataAnnotations;

namespace SistemaClinico.Models.Clinica
{
	public class Empleado
	{
		public int idEmpleado { get; set; }

		[Required(ErrorMessage = "El apellido materno es obligatorio")]
		public string apMaterno { get; set; }

		[Required(ErrorMessage = "El apellido paterno es obligatorio")]
		public string apPaterno { get; set; }

		[Required(ErrorMessage = "La clave es obligatoria")]
		public string clave { get; set; }

		[Required(ErrorMessage = "El estado es obligatorio")]
		public string estado { get; set; }
		//public bool estado {  get; set; }

		[Required(ErrorMessage = "La imagen es obligatoria")]
		public string imagen { get; set; }

		[Required(ErrorMessage = "El nombre es obligatorio")]
		public string nombres { get; set; }

		[Required(ErrorMessage = "El número de documento es obligatorio")]
		public string nroDocumento { get; set; }

		[Required(ErrorMessage = "El usuario es obligatorio")]
		public string usuario { get; set; }

		[Required(ErrorMessage = "El tipo de empleado es obligatorio")]
		public int idTipoEmpleado { get; set; }
		public TipoEmpleado? tipoEmpleado { get; set; }
	}
}