using System.ComponentModel.DataAnnotations;

namespace SistemaClinico.Models.Clinica
{
	public class Paciente
	{
		public int idPaciente { get; set; }

		[Required(ErrorMessage ="El apellido materno es obligatorio")]
		public string apMaterno { get; set; }

		[Required(ErrorMessage ="El apellido paterno es obligatorio")]
		public string apPaterno { get; set; }

		[Required(ErrorMessage ="La dirección es obligatorio")]
		public string direccion {  get; set; }

		[Required, Range(18,120,ErrorMessage ="La edad debe estar entre 18 y 120 años")]
		public int edad {  get; set; }

		[Required(ErrorMessage ="El estado es obligatorio")]
		public string estado { get; set; }

		[Required(ErrorMessage ="La imagen es obligatoria")]
		public string imagen { get; set; }

		[Required(ErrorMessage ="El nombre es obligatorio")]
		public string nombres { get; set; }

		[Required(ErrorMessage ="El número de documento es obligatorio")]
		public string nroDocumento { get; set; }

		[Required(ErrorMessage ="El sexo es obligatorio")]
		public string sexo { get; set; }

		[Required(ErrorMessage ="El teléfono es obligatorio")]
		public string telefono { get; set; }
	}
}