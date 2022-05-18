using Microsoft.AspNetCore.Mvc.Rendering;

namespace ScriptAkademy.Models.ViewModels
{
    public class ProductoE
    {

        public Producto oProducto { get; set; }

        public List<SelectListItem> listadoEstadoP { get; set; }

        public List<SelectListItem> listadoTipoP { get; set; }

        public List<SelectListItem> listadoUsuario { get; set; }

    }
}
