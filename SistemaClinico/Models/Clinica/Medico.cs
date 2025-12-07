using System.ComponentModel.DataAnnotations;

namespace SistemaClinico.Models.Clinica
{
	public class Medico
	{
		public int idMedico { get; set; }

		[Required(ErrorMessage ="El estado es obligatorio")]
		public string estado { get; set; }

		[Required(ErrorMessage ="El nombre del empleado es obligatorio")]
		public int idEmpleado { get; set; }
		public Empleado empleado { get; set; }

		[Required(ErrorMessage ="La especialidad es obligatoria")]
		public int idEspecialidad { get; set; }
		public Especialidad especialidad { get; set; }
	}
}