using System;
using System.Collections.Generic;

namespace ScriptAkademy.Models
{
    public partial class Producto
    {
        public Producto()
        {
            DetalleVenta = new HashSet<DetalleVenta>();
        }

        public int IdProductos { get; set; }
        public string Nombre { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public int IdestadoProducto { get; set; }
        public int IdtipoProducto { get; set; }
        public int IdUsuario { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
        public virtual EstadoProducto IdestadoProductoNavigation { get; set; } = null!;
        public virtual TipoProducto IdtipoProductoNavigation { get; set; } = null!;
        public virtual ICollection<DetalleVenta> DetalleVenta { get; set; }
    }
}
