using System;
using System.Collections.Generic;

namespace ScriptAkademy.Models
{
    public partial class TipoUsuario
    {
        public TipoUsuario()
        {
            Usuarios = new HashSet<Usuario>();
        }

        public int IdtipoUsuario { get; set; }
        public string TipoUsuario1 { get; set; } = null!;

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
