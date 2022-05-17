using System;
using System.Collections.Generic;

namespace ScriptAkademy.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Productos = new HashSet<Producto>();
        }

        public int IdUsuario { get; set; }
        public string Nombre { get; set; } = null!;
        public string Contrasena { get; set; } = null!;
        public string Dui { get; set; } = null!;
        public string Celular { get; set; } = null!;
        public string? Correo { get; set; }
        public int IdestadoUsuario { get; set; }
        public int IdtipoUsuario { get; set; }

        public virtual EstadoUsuario oEstadoUsuario { get; set; } = null!;
        public virtual TipoUsuario oTipoUsuario { get; set; } = null!;
        public virtual ICollection<Producto> Productos { get; set; }
    }
}
