using System.ComponentModel.DataAnnotations;

namespace SistemaClinico.Models.Clinica
{
    public class DiaSemana
    {
        public int idDiaSemana { get; set; }

        [Required(ErrorMessage ="El nombre del día de la semana es obligatorio")]
        public string nombreDiaSemana { get; set; }
    }
}