using System.ComponentModel.DataAnnotations;

namespace SistemaClinico.Models.Clinica
{
    public class Especialidad
    {
        public int idEspecialidad {  get; set; }

        [Required(ErrorMessage ="La descipción es obligatoria")]
        public string descripcion { get; set; }

        [Required(ErrorMessage ="El estado es obligatorio")]
        public string estado { get; set; }
    }
}