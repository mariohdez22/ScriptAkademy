using System;
using System.Collections.Generic;

namespace ScriptAkademy.Models
{
    public partial class DetalleVenta
    {
        public int IddetalleVenta { get; set; }
        public int IdVenta { get; set; }
        public int IdProductos { get; set; }
        public int Cantidad { get; set; }

        public virtual Producto IdProductosNavigation { get; set; } = null!;
        public virtual Venta IdVentaNavigation { get; set; } = null!;
    }
}
