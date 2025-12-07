using System.ComponentModel.DataAnnotations;

namespace SistemaClinico.Models.Clinica
{
	public class HorarioAtencion
	{
		public int idHorarioAtencion { get; set; }

		[Required(ErrorMessage ="El estado es obligatorio")]
		public string estado { get; set; }

		[Required(ErrorMessage ="La fecha es obligatoria")]
		public DateTime fecha { get; set; }

		[Required(ErrorMessage ="La fecha fin es obligatoria")]
		public DateTime fechaFin {  get; set; }

		[Required(ErrorMessage ="El dia de semana es obligatorio")]
		public int idDiaSemana { get; set; }
		public DiaSemana diaSemana { get; set; }

		[Required(ErrorMessage ="La hora es obligatoria")]
		public int idHora { get; set; }
		public Hora hora { get; set; }

		[Required(ErrorMessage ="El medico es obligatorio")]
		public int idMedico { get; set; }
		public Medico medico { get; set; }
	}
}