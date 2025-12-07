using System.ComponentModel.DataAnnotations;

namespace SistemaClinico.Models.Clinica
{
    public class TipoEmpleado
    {
        public int idTipoEmpleado {  get; set; }

        [Required(ErrorMessage ="La descripción es obligatoria")]
        public string descripcion { get; set; }

        [Required(ErrorMessage ="El estado es obligatorio")]
        public string estado { get; set; }
    }
}