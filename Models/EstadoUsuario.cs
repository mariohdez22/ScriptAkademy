using System;
using System.Collections.Generic;

namespace ScriptAkademy.Models
{
    public partial class EstadoUsuario
    {
        public EstadoUsuario()
        {
            Usuarios = new HashSet<Usuario>();
        }

        public int IdestadoUsuario { get; set; }
        public string EstadoUsuario1 { get; set; } = null!;

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
