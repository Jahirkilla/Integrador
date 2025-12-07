using System.ComponentModel.DataAnnotations;


namespace SistemaClinico.Models.Clinica
{
	public class Cita
	{
		public int idCita { get; set; }

		[Required(ErrorMessage ="El estado es obligatorio")]
		public string estado { get; set; }

		[Required(ErrorMessage ="La fecha de reserva es obligatorio")]
		public DateTime fechaReserva { get; set; }

		[Required(ErrorMessage ="La hora es obligatoria")]
		public string hora { get; set; }

		[Required(ErrorMessage ="La observacion es obligatoria")]
		public string observacion { get; set; }

		[Required(ErrorMessage ="El horario de atencion es obligatorio")]
		public int idHorarioAtencion { get; set; }
		public HorarioAtencion horarioAtencion { get; set; }

		[Required(ErrorMessage ="El paciente es obligatorio")]
		public int idPaciente { get; set; }
		public Paciente paciente { get; set; }
	}
}