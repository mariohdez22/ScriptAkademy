using System;
using System.Collections.Generic;

namespace ScriptAkademy.Models
{
    public partial class Venta
    {
        public Venta()
        {
            DetalleVenta = new HashSet<DetalleVenta>();
        }

        public int IdVenta { get; set; }
        public decimal Total { get; set; }
        public DateTime Fecha { get; set; }
        public int Idcliente { get; set; }

        public virtual Cliente IdclienteNavigation { get; set; } = null!;
        public virtual ICollection<DetalleVenta> DetalleVenta { get; set; }
    }
}
