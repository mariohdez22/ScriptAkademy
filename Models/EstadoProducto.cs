using System;
using System.Collections.Generic;

namespace ScriptAkademy.Models
{
    public partial class EstadoProducto
    {
        public EstadoProducto()
        {
            Productos = new HashSet<Producto>();
        }

        public int IdestadoProducto { get; set; }
        public string EstadoProducto1 { get; set; } = null!;

        public virtual ICollection<Producto> Productos { get; set; }
    }
}
