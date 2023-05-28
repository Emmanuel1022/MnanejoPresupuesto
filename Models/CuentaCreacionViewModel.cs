using Microsoft.AspNetCore.Mvc.Rendering;

namespace MnanejoPresupuesto.Models
{
    public class CuentaCreacionViewModel: Cuenta
    {
        public IEnumerable<SelectListItem> TiposCuentas { get; set; }
    }
}
