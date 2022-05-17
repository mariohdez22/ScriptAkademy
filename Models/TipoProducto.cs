using System;
using System.Collections.Generic;

namespace ScriptAkademy.Models
{
    public partial class TipoProducto
    {
        public TipoProducto()
        {
            Productos = new HashSet<Producto>();
        }

        public int IdtipoProducto { get; set; }
        public string TipoProducto1 { get; set; } = null!;

        public virtual ICollection<Producto> Productos { get; set; }
    }
}
