using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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

        public virtual Usuario oUsuariosP { get; set; } = null!;
        public virtual EstadoProducto oEstadoProducto { get; set; } = null!;
        public virtual TipoProducto oTipoProducto { get; set; } = null!;
        public virtual ICollection<DetalleVenta> DetalleVenta { get; set; }
    }
}
