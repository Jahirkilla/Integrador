using System.ComponentModel.DataAnnotations;

namespace SistemaClinico.Models.Clinica
{
	public class Hora
	{
		public int idHora { get; set; }

		[Required(ErrorMessage ="La hora es obligatoria")]
		public string hora { get; set; }
	}
}