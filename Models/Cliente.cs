using System;
using System.Collections.Generic;

namespace ScriptAkademy.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            Venta = new HashSet<Venta>();
        }

        public int IdCliente { get; set; }
        public string Nombre { get; set; } = null!;
        public string Correo { get; set; } = null!;
        public string? Contrasena { get; set; }

        public virtual ICollection<Venta> Venta { get; set; }
    }
}
