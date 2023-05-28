using System.ComponentModel.DataAnnotations;

namespace MnanejoPresupuesto.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Elcampo {0} es requerido")]
        [StringLength(maximumLength: 50, ErrorMessage ="No puede ser mayor a {1} caracteres")]
        public string Nombre { get; set; }
        [Display(Name ="Tipo Operacion")]
        public TipoOperacion TipoOperacionId { get; set; }    
        public int UsuarioId { get; set; }
    }
}
